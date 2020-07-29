﻿using Geometry.Abstractions.Triangle;

namespace Geometry.Logic.Resolvers
{
    public class IsoscelesResolver : ITriangleTypeResolver
    {
        public ITriangleTypeMatch ResolveType(ITriangle triangle)
        {
            var isIsosceles = (triangle.A == triangle.B && triangle.A != triangle.C)
                                  || (triangle.B == triangle.C && triangle.B != triangle.A)
                                  || (triangle.C == triangle.A && triangle.C != triangle.B);

            return new TriangleTypeMatch(TriangleType.Isosceles, isIsosceles);
        }
    }
}
