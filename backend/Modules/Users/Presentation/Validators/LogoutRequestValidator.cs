// <copyright file="LogoutRequestValidator.cs" company="Gabriel Passarinho Garcia and EleveRats Team">
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

using EleveRats.Modules.Users.Presentation.Contracts;
using FluentValidation;

namespace EleveRats.Modules.Users.Presentation.Validators;

/// <summary>
/// Validator for the <see cref="LogoutRequest"/> DTO.
/// </summary>
public sealed class LogoutRequestValidator : AbstractValidator<LogoutRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LogoutRequestValidator"/> class.
    /// </summary>
    public LogoutRequestValidator()
    {
        RuleFor(x => x.RefreshToken)
            .NotEmpty()
            .WithMessage("O Refresh Token é obrigatório.")
            .MaximumLength(512)
            .WithMessage("O Refresh Token é muito longo.");
    }
}
