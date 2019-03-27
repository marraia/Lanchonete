using Lanchonete.Dominio.Modelos;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Lanchonete.Repositorio.Contexto
{
    public class LanchoneteContexto
    {
        private readonly IMongoDatabase _mongoDatabase;

        public LanchoneteContexto(string servidor, string database)
        {
            var conventionPack = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("camelCase", conventionPack, t => true);

            var client = new MongoClient(servidor);
            _mongoDatabase = client.GetDatabase(database);
        }

        public IMongoCollection<Pedido> Pedidos =>
            _mongoDatabase.GetCollection<Pedido>("Pedidos");
    }
}
