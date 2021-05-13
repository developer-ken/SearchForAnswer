using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    public class Structs
    {
        public enum QuestionType
        {
            MultiSelection = 1, Others = -1
        }
        public struct SearchInput
        {
            public string Keywords;
            public QuestionType Type;
        }
        public struct SearchResult
        {
            public string Answer;
            public string ServerMessage;
        }
        public struct EngineInfo
        {
            public string Name, Author, Provider, Message;
            public int RatelimitPerHour;
        }
    }
}
