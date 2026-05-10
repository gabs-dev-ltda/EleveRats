// <copyright file="ValidationFilter.cs" company="Gabriel Passarinho Garcia and EleveRats Team">
// Copyright (C) 2026 Gabriel Passarinho Garcia and EleveRats Team
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see &lt;https://www.gnu.org/licenses/&gt;.
// </copyright>

using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace EleveRats.Core.Infra.Web.Filters;

/// <summary>
/// A generic validation filter for Minimal API endpoints that uses FluentValidation.
/// </summary>
/// <typeparam name="T">The type of the request object to validate.</typeparam>
public sealed class ValidationFilter<T> : IEndpointFilter
{
    /// <inheritdoc/>
    public async ValueTask<object?> InvokeAsync(
        EndpointFilterInvocationContext context,
        EndpointFilterDelegate next
    )
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(next);

        T? request = context.GetArgument<T>(0);

        if (request is null)
        {
            return Results.BadRequest("Request body cannot be empty.");
        }

        IValidator<T>? validator = context.HttpContext.RequestServices.GetService<IValidator<T>>();

        if (validator is not null)
        {
            ValidationResult result = await validator.ValidateAsync(
                request,
                context.HttpContext.RequestAborted
            );

            if (!result.IsValid)
            {
                return Results.ValidationProblem(result.ToDictionary());
            }
        }

        return await next(context);
    }
}
