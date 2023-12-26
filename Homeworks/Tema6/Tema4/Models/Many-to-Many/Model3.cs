using Tema4.Models2.Base;

namespace Tema4.Models.Many_to_Many
{
    public class Model3: BaseEntity
    {
        public string? Name { get; set; }

        //public ICollection<Model4> Models4 { get; set; }   

        public ICollection<ModelsRelation> ModelsRelations {  get; set; }
    }
}
