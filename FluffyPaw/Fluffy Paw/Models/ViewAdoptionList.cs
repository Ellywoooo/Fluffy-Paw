using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluffy_Paw.Models
{
    public class ViewAdoptionList: INotifyPropertyChanged
    {
        private ObservableCollection<AdoptionList> items;
        public ObservableCollection<AdoptionList> Items
        {
            get { return items; }
            set
            {
                items = value;
                OnPropertyChanged(nameof(Items));
            }
        }
        public ViewAdoptionList()
        {
            // Initialize Items with your data
           Items = new ObservableCollection<AdoptionList>
            {
                new AdoptionList { Animal = "Cat", Name = "Choco", Species = "Ragdoll", Email = "cifeja6494@weirby.com", Age = "3",
                    Gender = "Female", Weight = 3.5, vaccinated = "Vaccinated", Image = "Assets/Ragdoll.jpg"
                },
                new AdoptionList { Animal = "Cat", Name = "Dolla", Species = "British Shorthair", Email = "e4ecb86538f4a8@lamasticots.com",
                                            Age = "4", Gender = "Male", Weight = 5.2, vaccinated = "Vaccinated", Image = "Assets/British Shorthair.jpg"
                },
                new AdoptionList { Animal = "Cat", Name = "Hana", Species = "Chinchilla", Email = "97fdcc6538f498@theeyeoftruth.com",
                                            Age = "10", Gender = "Male", Weight = 6.7, vaccinated = "Vaccinated", Image = "Assets/Chinchilla.jpg"
                },
                new AdoptionList { Animal = "Cat", Name = "Dull", Species = "British Shorthair", Email = "rudikcan@1resep.art",
                                            Age = "1", Gender = "Female", Weight = 7.8, vaccinated = "Vaccinated", Image = "Assets/British Shorthair2.jpg"
                },
                new AdoptionList { Animal = "Cat", Name = "Mimi", Species = "Bengal", Email = "rudikcan@1resep.art",
                                            Age = "2", Gender = "Female", Weight = 5.5, vaccinated = "Vaccinated", Image = "Assets/Bengal.jpg"
                },
                new AdoptionList { Animal = "Cat", Name = "Mori", Species = "Persian", Email = "cifeja6494@weirby.com",
                                            Age = "1", Gender = "Male", Weight = 3.8, vaccinated = "Vaccinated", Image = "Assets/Persian.jpg"
                },
                new AdoptionList { Animal = "Cat", Name = "Dori", Species = "American Shorthair", Email = "rudikcan@1resep.art",
                                            Age = "2", Gender = "Female", Weight = 6.5, vaccinated = "Vaccinated", Image = "Assets/American Shorthair.jpg"
                },

                new AdoptionList { Animal = "Dog", Name = "Shung", Species = "Beaglier", Email = "be5b4b6538f4b5@lamasticots.com",
                                            Age = "4", Gender = "Male", Weight = 4.6, vaccinated = "Vaccinated", Image = "Assets/Beaglier.jpg"
                },
                new AdoptionList { Animal = "Dog", Name = "Bell", Species = "Bichon Frise", Email = "3ed8dd6538f4c0@lamasticots.com",
                                            Age = "5", Gender = "Female", Weight = 6.5, vaccinated = "Vaccinated", Image = "Assets/Bichon Frise.jpg"
                },
                new AdoptionList { Animal = "Dog", Name = "Hari", Species = "Chihuahua", Email = "d763526538f4c8@theeyeoftruth.com",
                                            Age = "11", Gender = "Male", Weight = 4.7, vaccinated = "Vaccinated", Image = "Assets/Chihuahua.jpg"
                },
                new AdoptionList { Animal = "Dog", Name = "Ari", Species = "Chihuahua", Email = "1cc7f46538f4ce@beaconmessenger.com",
                                            Age = "2", Gender = "Female", Weight = 3.2, vaccinated = "Vaccinated", Image = "Assets/Chihuahua2.jpg"
                },
                new AdoptionList { Animal = "Dog", Name = "Kabi", Species = "Golden Retriever", Email = "96335f6538f4d4@beaconmessenger.com",
                                            Age = "1", Gender = "Female", Weight = 7.5, vaccinated = "Vaccinated", Image = "Assets/Golden Retriever.jpg"
                },   
                new AdoptionList { Animal = "Dog", Name = "Jojo", Species = "Poodle", Email = "1cc7f46538f4ce@beaconmessenger.com",
                                            Age = "2", Gender = "Female", Weight = 3.2, vaccinated = "Vaccinated", Image = "Assets/Poodle.jpg"
                },
                new AdoptionList { Animal = "Dog", Name = "Buri", Species = "Pomeranian", Email = "96335f6538f4d4@beaconmessenger.com",
                                            Age = "1", Gender = "Female", Weight = 5.5, vaccinated = "Vaccinated", Image = "Assets/Pomeranian.jpg"
                },

               new AdoptionList {  Animal = "Bird", Name = "Cucu", Species = "Budgerigar", Email = "0046fa6538f4dc@lamasticots.com",
                                            Age = "5", Gender = "Female", Weight = 0.07, vaccinated = "Vaccinated", Image = "Assets/Budgerigar.jpg"
                },
                new AdoptionList { Animal = "Bird", Name = "Bell", Species = "Cockatiel", Email = "121b0c6538f4e2@lamasticots.com",
                                            Age = "2", Gender = "Male", Weight = 0.1, vaccinated = "Vaccinated", Image = "Assets/Cockatiel.jpg"
                },
                new AdoptionList {  Animal = "Bird", Name = "Mina", Species = "Cockatoo", Email = "f4d7c06538f4ea@beaconmessenger.com",
                                            Age = "3", Gender = "Female", Weight = 0.08, vaccinated = "Vaccinated", Image = "Assets/Cockatoo.jpg"
                },    
                new AdoptionList {  Animal = "Bird", Name = "Gogi", Species = "Parrots", Email = "0046fa6538f4dc@lamasticots.com",
                                            Age = "2", Gender = "Female", Weight = 0.07, vaccinated = "Vaccinated", Image = "Assets/Parrots.jpg"
                },
                new AdoptionList { Animal = "Bird", Name = "Queen", Species = "Cockatoo", Email = "121b0c6538f4e2@lamasticots.com",
                                            Age = "7", Gender = "Male", Weight = 0.1, vaccinated = "Vaccinated", Image = "Assets/Cockatoos1.jpg"
                },
                new AdoptionList {  Animal = "Bird", Name = "Mosi", Species = "Macaw", Email = "f4d7c06538f4ea@beaconmessenger.com",
                                            Age = "3", Gender = "Female", Weight = 0.08, vaccinated = "Vaccinated", Image = "Assets/Macaw.jpg"
                },


                new AdoptionList {  Animal = "Rabbit", Name = "Coco", Species = "White Hotot", Email = "b0eca8ef@theeyeoftruth.com",
                                            Age = "1", Gender = "Female", Weight = 1.0, vaccinated = "Vaccinated", Image = "Assets/White Hotot.jpg"
                }, 
               new AdoptionList {  Animal = "Rabbit", Name = "Juju", Species = "Cinnamon", Email = "38f4ef@theeyeoftruth.com",
                                            Age = "2", Gender = "Female", Weight = 0.7, vaccinated = "Vaccinated", Image = "Assets/Cinnamon.jpg"
                }, 
               
               new AdoptionList {  Animal = "Hamster", Name = "Choco", Species = "Golden Hamster", Email = "f6a9986538f4fe@lamasticots.com",
                                            Age = "1", Gender = "Female", Weight = 0.11, vaccinated = "Vaccinated", Image = "Assets/Golden Hamster.jpg"
               },
                
               new AdoptionList {  Animal = "Hamster", Name = "Choco", Species = "Dwarf Winter White Russian", Email = "86538f4fe@lamasticots.com",
                                            Age = "0.5", Gender = "Male", Weight = 0.02, vaccinated = "Vaccinated", Image = "Assets/Dwarf Winter White Russian.jpg"
               },
               new AdoptionList {  Animal = "Hamster", Name = "Choco", Species = "Dwarf Roborovski", Email = "a3ff3c6538f50e@beaconmessenger.com",
                                            Age = "0.3", Gender = "Female", Weight = 0.03, vaccinated = "Vaccinated", Image = "Assets/Dwarf Roborovski.jpg"
               },
            };
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
