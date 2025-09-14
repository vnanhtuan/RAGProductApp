using Microsoft.Extensions.VectorData;

namespace RAGMovieApp
{
    public class Product
    {
        [VectorStoreKey]
        public Guid Key { get; set; } = Guid.NewGuid();
        [VectorStoreData]
        public string? Name { get; set; } = null;
        [VectorStoreData]
        public string? Description { get; set; } = null;
        [VectorStoreData]
        public string? Type { get; set; } = null;
        [VectorStoreData]
        public float? Price { get; set; } = null;
        [VectorStoreData]
        public string? Reference { get; set; } = null;


        [VectorStoreVector(768, DistanceFunction = DistanceFunction.CosineSimilarity)]
        public ReadOnlyMemory<float>? DescriptionEmbedding { get; set; }
        
        
    }
}
