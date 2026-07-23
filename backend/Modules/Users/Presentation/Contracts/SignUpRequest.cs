// <copyright file="SignUpRequest.cs" company="Gabriel Passarinho Garcia and EleveRats Team">
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

using System;
using EleveRats.Modules.Users.Domain.Enums;

namespace EleveRats.Modules.Users.Presentation.Contracts;

/// <summary>
/// Data Transfer Object containing the request payload for a user signup.
/// </summary>
/// <param name="Email">The user's email address (serves as login identity).</param>
/// <param name="Password">The raw password provided by the user.</param>
/// <param name="FullName">The user's full name.</param>
/// <param name="BirthDate">The user's date of birth.</param>
/// <param name="Gender">The user's gender.</param>
/// <param name="OrganizationId">The ID of the organization (tenant) the user is signing up for.</param>
internal record SignUpRequest(
    string Email,
    string Password,
    string FullName,
    DateOnly BirthDate,
    Gender Gender,
    Guid OrganizationId
);
