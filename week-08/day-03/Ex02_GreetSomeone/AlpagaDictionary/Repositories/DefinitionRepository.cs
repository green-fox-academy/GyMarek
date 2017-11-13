using AlpagaDictionary.Entities;
using AlpagaDictionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlpagaDictionary.Repositories
{
    public class DefinitionRepository
    {
        private Context DefinitionsContext;

        public List<Definition> GetList()
        {
            return DefinitionsContext.DefinitionData.ToList();
        }

        public DefinitionRepository(Context definitionsContext)
        {
            DefinitionsContext = definitionsContext;
        }

        public void AddDefinition(string definitionName, string definitonDescription)
        {
            var definition = new Definition()
            {
                DefinitionName = definitionName,
                DefinitonDescription = definitonDescription,
            };

            DefinitionsContext.DefinitionData.Add(definition);
            DefinitionsContext.SaveChanges();
        }

        public void DeleteDefinition(int id)
        {
            var deleteItem = from deleteOne in DefinitionsContext.DefinitionData
                             where deleteOne.Id == id
                             select deleteOne;

            DefinitionsContext.DefinitionData.Remove(deleteItem.FirstOrDefault());
            DefinitionsContext.SaveChanges();
        }

        public Definition Updating(int id)
        {
            return DefinitionsContext.DefinitionData.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateDefinition(Definition definition)
        {
            DefinitionsContext.DefinitionData.Update(definition);
            DefinitionsContext.SaveChanges();
        }
    }
}
