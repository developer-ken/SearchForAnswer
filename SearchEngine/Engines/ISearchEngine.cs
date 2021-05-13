namespace SearchEngine.Engines
{
    public interface ISearchEngine
    {
        public Structs.SearchResult Search(Structs.SearchInput input);
        public Structs.EngineInfo EngineInfo { get; }
        public bool Loaded { get; }
    }
}
