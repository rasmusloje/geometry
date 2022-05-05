﻿using System.Collections.Generic;

namespace Geometry.Abstractions.Triangle;

public interface ITriangleTypeService
{
    IReadOnlyCollection<TriangleType> DetermineTypes(ITriangle triangle);
}