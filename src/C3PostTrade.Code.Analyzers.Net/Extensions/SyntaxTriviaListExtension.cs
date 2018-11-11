using Microsoft.CodeAnalysis;
using System.Linq;

namespace C3PostTrade.Code.Analyzers.Net.Extensions
{
    public static class SyntaxTriviaListExtension
    {
        public static bool AnyDocumentationTrivia(this SyntaxTriviaList syntaxTriviaList)
        {
            return syntaxTriviaList.OfType<SyntaxTrivia>().Any(x => x.IsDocumentationAvailable());    
        }
    }
}
