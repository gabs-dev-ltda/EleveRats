// <copyright file="SignUpResponse.cs" company="Gabriel Passarinho Garcia and EleveRats Team">
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

namespace EleveRats.Modules.Users.Presentation.Contracts;

/// <summary>
/// Data Transfer Object representing the successful response payload after a user signup.
/// </summary>
/// <param name="UserId">The newly generated unique user identifier (UUID v7).</param>
/// <param name="ProfileId">The newly generated unique profile identifier (UUID v7).</param>
/// <param name="Email">The user's registered email address.</param>
/// <param name="FullName">The user's full name.</param>
/// <param name="OrganizationId">The ID of the organization (tenant) associated with the profile.</param>
/// <param name="CreatedAt">The timestamp when the user was created.</param>
public record SignUpResponse(
    Guid UserId,
    Guid ProfileId,
    string Email,
    string FullName,
    Guid OrganizationId,
    DateTimeOffset CreatedAt
    );
