using System.Collections.Generic;


namespace TransportRent.Models {
    public class MockCategoryRepository : ICategoryRepository {
        public IEnumerable<Category> GetCategories {
            get {
                return new List<Category> {
                    new Category() {
                        Id = 1,
                        Name = "Big"
                    },
                    new Category() {
                        Id = 2,
                        Name = "Small"
                    },
                    new Category() {
                        Id = 3,
                        Name = "Medium"
                    }
                };
            }
        }
    }
}
