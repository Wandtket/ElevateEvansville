using System.Linq.Expressions;

namespace ElevateEvansville_API.Extensions.Sorting
{
    internal class OrderMethodFinder : ExpressionVisitor
    {

        internal bool OrderByFound = false;

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Method.Name == "OrderBy" || node.Method.Name == "OrderByDescending")
            {
                OrderByFound = true;
            }

            return base.VisitMethodCall(node);
        }
    }
}
