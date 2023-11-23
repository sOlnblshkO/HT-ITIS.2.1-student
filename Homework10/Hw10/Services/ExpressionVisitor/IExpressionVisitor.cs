﻿using System.Linq.Expressions;

namespace Hw10.Services.MyExpressionVisitor;

public interface IExpressionVisitor
{
    public Expression VisitExpression(Expression expression);
}