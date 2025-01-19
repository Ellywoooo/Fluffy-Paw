using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluffy_Paw.Models
{
    public class MnSList
    {
        public string MorS { get; set; }
        public string Animal { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }

        public string Time { get; set; }
    }

    public class MnSBoard
    {
        public static List<MnSList> GetLists()
        {
            var animal = new List<MnSList>();

            animal.Add(new MnSList { MorS = "Missing", Animal = "Cat", Name = "Madison", Species = "Ragdoll", Age = "2", Email = "b9ae9b652f4f77@theeyeoftruth.com", Gender = "Male", 
                Image = "Assets/Ragdoll1.jpg", Time = "03/06/2023 3:00 pm", Location = "111 SH 30A, Owhata, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Missing", Animal = "Dog", Name = "Ruke", Species = "Chihuahua", Age = "3", Email = "48a223652f4f81@lamasticots.com", Gender = "Male", 
                Image = "Assets/Chihuahua3.jpg", Time = "28/03/2023 3:00 pm", Location = "147 Hayward Rise, Rotorua, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Missing", Animal = "Dog", Name = "Rum", Species = "Beaglier", Age = "2", Email = "8cf762652f4f85@theeyeoftruth.com", Gender = "Female", 
                Image = "Assets/Beaglier1.jpg", Time = "24/05/2023 3:00 pm", Location = "191 Miro Street, Fairy Springs, Rotorua, 3015, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Missing", Animal = "Cat", Name = "Mady", Species = "Mix", Age = "6", Email = "9e9fba652f4f88@lamasticots.com", Gender = "Male", 
                Image = "Assets/Mix.jpg", Time = "25/09/2023 3:00 pm", Location = "150 Hemo Road, Rotorua, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Missing", Animal = "Cat", Name = "Jas", Species = "Bengal", Age = "4", Email = "66e38c652f4f8b@theeyeoftruth.com", Gender = "Male", 
                Image = "Assets/Bengal.jpg", Time = "23/09/2023 3:00 pm", Location = "72 Elliott Crescent, Glenholme, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Missing", Animal = "Dog", Name = "Pay", Species = "Beaglier", Age = "1", Email = "9835d7652f4f8f@lamasticots.com", Gender = "Male",
                Image = "Assets/Beaglier2.jpg", Time = "13/09/2023 3:00 pm", Location = "170 Hilda Street, Owhata, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Missing", Animal = "Rabbit", Name = "Maia", Species = "Cinnamon", Age = "1", Email = "12e4d9652f4f92@beaconmessenger.com", Gender = "Female",
                Image = "Assets/Cinnamon.jpg", Time = "08/10/2023 3:00 pm", Location = "58 Church Road, Owhata, Kawaha Point, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Missing", Animal = "Cat", Name = "Jedi", Species = "Bengal", Age = "8", Email = "c338ec652f4f96@lamasticots.com", Gender = "Female", 
                Image = "Assets/Bengal2.jpg", Time = "08/10/2023 3:00 pm", Location = "217 Rika Place,Koutu, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Missing", Animal = "Bird", Name = "Patty", Species = "Cockatoo", Age = "3", Email = "5422aa652f4f99@theeyeoftruth.com", Gender = "Male", 
                Image = "Assets/Cockatoo.jpg", Time = "01/10/2023 3:00 pm", Location = "190 Rangiuru Street, Victoria, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Missing", Animal = "Dog", Name = "Mak", Species = "Chihuahua", Age = "6", Email = "a75a43652f4f9c@beaconmessenger.com", Gender = "Female", 
                Image = "Assets/Chihuahua4.jpg", Time = "13/08/2023 3:00 pm", Location = "205 Susan Street, Hillcrest, Rotorua, 3015, New Zealand"
            });

            animal.Add(new MnSList { MorS = "Sighting", Animal = "Dog", Species = "Golden Retriever", Email = "9514e0652f5342@theeyeoftruth.com", Gender = "Female", 
                Image = "Assets/Golden Retriever.jpg", Time = "03/06/2023 3:00 pm", Location = "33 Cherrywood Place, Fordlands, Rotorua, 3015, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Sighting", Animal = "Dog", Species = "Bichon Frise", Email = "a75a43652f4f9c@beaconmessenger.com", Gender = "Unknown", 
                Image = "Assets/Bichon Frise.jpg", Time = "16/07/2023 3:00 pm", Location = "195 Kahikatea Street, Whakarewarewa, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Sighting", Animal = "Cat", Species = "British Shorthair", Email = "d62a4e652f535b@theeyeoftruth.com", Gender = "Unknown", 
                Image = "Assets/British Shorthair2.jpg", Time = "23/06/2023 3:00 pm", Location = "237 Bertram Street, West Brook, Rotorua, 3015, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Sighting", Animal = "Cat", Species = "Unknown", Email = "1a08af652f5361@beaconmessenger.com", Gender = "Male", 
                Image = "Assets/Persian.jpg", Time = "14/04/2023 3:00 pm", Location = "219 Moncur Drive, Westbrook, Rotorua, 3015, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Sighting", Animal = "Cat", Species = "British Shorthair", Email = "c6a2f9652f5366@theeyeoftruth.com", Gender = "Male", 
                Image = "Assets/British Shorthair.jpg", Time = "11/05/2023 3:00 pm", Location = "72 Maisey Place, Western Heights, Rotorua, 3015, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Sighting", Animal = "Dog", Species = "Unknown", Email = "a8f3dfd652f536b@lamasticots.com", Gender = "Unknown", 
                Image = "Assets/Pomeranian.jpg", Time = "07/10/2023 3:00 pm", Location = "133 Florey Heights, Westbrook, Rotorua, 3015, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Sighting", Animal = "Dog", Species = "Chihuahua", Email = "b2d0bb652f5371@beaconmessenger.com", Gender = "Unknown", 
                Image = "Assets/Chihuahua2.jpg", Time = "04/08/2023 3:00 pm", Location = "129 Egmont Road, Koutu, Rotorua, 3010, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Sighting", Animal = "Cat", Species = "Unknown", Email = "668bd2652f537f@lamasticots.com", Gender = "Female", 
                Image = "Assets/American Shorthair.jpg", Time = "23/09/2023 3:00 pm", Location = "30 Cherrywood Place, Westbrook, Rotorua, 3015, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Sighting", Animal = "Hamster", Species = "Golden Hamster", Email = "f97859652f5387@lamasticots.com", Gender = "Unknown", 
                Image = "Assets/Golden Hamster.jpg", Time = "03/10/2023 3:00 pm", Location = "148 Helena Place, Hillcrest, Rotorua, 3015, New Zealand"
            });
            animal.Add(new MnSList { MorS = "Sighting", Animal = "Dog", Species = "Unknown", Email = "a63ff1d652f538c@theeyeoftruth.com", Gender = "Male",
                Image = "Assets/Poodle.jpg", Time = "13/09/2023 3:00 pm", Location = "238 Kusabs Road, Fordlands, Rotorua, 3015, New Zealand"
            });


            return animal;
        }
    }
}
