using Microsoft.Extensions.VectorData;

namespace RAGMovieApp
{
    public class Movie
    {
        [VectorStoreKey]
        public Guid Key { get; set; } = Guid.NewGuid();
        [VectorStoreData]
        public string? Title { get; set; } = null;
        [VectorStoreData]
        public string? Reference { get; set; } = null;
        [VectorStoreData]
        public string? Description { get; set; } = null;
        [VectorStoreVector(768, DistanceFunction = DistanceFunction.CosineSimilarity)]
        public ReadOnlyMemory<float>? DescriptionEmbedding { get; set; }

    }
}