using HitungAngsuranMobile.Models;
using HitungAngsuranMobile.Repositories.Contracts;

namespace HitungAngsuranMobile.Repositories.Logics
{
    public class JsonDataUserRepository : IJsonDataUserRepository
    {
        private List<JsonDataUser> Data()
        {
            List<JsonDataUser> data = [
                new JsonDataUser {
                    Name= "Adeel Solangi",
                    Language= "Sindhi",
                    Id= "V59OF92YF627HFY0",
                    Bio= "Donec lobortis eleifend condimentum. Cras dictum dolor lacinia lectus vehicula rutrum. Maecenas quis nisi nunc. Nam tristique feugiat est vitae mollis. Maecenas quis nisi nunc.",
                    Version= 6.1
                },
                new JsonDataUser {
                    Name = "Afzal Ghaffar",
                    Language = "Sindhi",
                    Id = "ENTOCR13RSCLZ6KU",
                    Bio = "Aliquam sollicitudin ante ligula, eget malesuada nibh efficitur et. Pellentesque massa sem, scelerisque sit amet odio id, cursus tempor urna. Etiam congue dignissim volutpat. Vestibulum pharetra libero et velit gravida euismod.",
                    Version = 1.88
                },
                new JsonDataUser {
                    Name = "Aamir Solangi",
                    Language = "Sindhi",
                    Id = "IAKPO3R4761JDRVG",
                    Bio = "Vestibulum pharetra libero et velit gravida euismod. Quisque mauris ligula, efficitur porttitor sodales ac, lacinia non ex. Fusce eu ultrices elit, vel posuere neque.",
                    Version = 7.27
                },
                new JsonDataUser {
                    Name = "Abla Dilmurat",
                    Language = "Uyghur",
                    Id = "5ZVOEPMJUI4MB4EN",
                    Bio = "Donec lobortis eleifend condimentum. Morbi ac tellus erat.",
                    Version = 2.53
                },
                new JsonDataUser {
                    Name = "Adil Eli",
                    Language = "Uyghur",
                    Id = "6VTI8X6LL0MMPJCC",
                    Bio = "Vivamus id faucibus velit, id posuere leo. Morbi vitae nisi lacinia, laoreet lorem nec, egestas orci. Suspendisse potenti.",
                    Version = 6.49
                },
                new JsonDataUser {
                    Name = "Adile Qadir",
                    Language = "Uyghur",
                    Id = "F2KEU5L7EHYSYFTT",
                    Bio = "Duis commodo orci ut dolor iaculis facilisis. Morbi ultricies consequat ligula posuere eleifend. Aenean finibus in tortor vel aliquet. Fusce eu ultrices elit, vel posuere neque.",
                    Version = 1.9
                },
                new JsonDataUser {
                    Name = "Abdukerim Ibrahim",
                    Language = "Uyghur",
                    Id = "LO6DVTZLRK68528I",
                    Bio = "Vivamus id faucibus velit, id posuere leo. Nunc aliquet sodales nunc a pulvinar. Nunc aliquet sodales nunc a pulvinar. Ut viverra quis eros eu tincidunt.",
                    Version = 5.9
                },
                new JsonDataUser {
                    Name = "Adil Abro",
                    Language = "Sindhi",
                    Id = "LJRIULRNJFCNZJAJ",
                    Bio = "Etiam malesuada blandit erat, nec ultricies leo maximus sed. Fusce congue aliquam elit ut luctus. Etiam malesuada blandit erat, nec ultricies leo maximus sed. Cras dictum dolor lacinia lectus vehicula rutrum. Integer vehicula, arcu sit amet egestas efficitur, orci justo interdum massa, eget ullamcorper risus ligula tristique libero.",
                    Version = 9.32
                },
                new JsonDataUser {
                    Name = "Afonso Vilarchán",
                    Language = "Galician",
                    Id = "JMCL0CXNXHPL1GBC",
                    Bio = "Fusce eu ultrices elit, vel posuere neque. Morbi ac tellus erat. Nunc tincidunt laoreet laoreet.",
                    Version = 5.21
                },
                new JsonDataUser {
                    Name = "Mark Schembri",
                    Language = "Maltese",
                    Id = "KU4T500C830697CW",
                    Bio = "Nam laoreet, nunc non suscipit interdum, justo turpis vestibulum massa, non vulputate ex urna at purus. Morbi ultricies consequat ligula posuere eleifend. Vivamus id faucibus velit, id posuere leo. Sed laoreet posuere sapien, ut feugiat nibh gravida at. Ut maximus, libero nec facilisis fringilla, ex sem sollicitudin leo, non congue tortor ligula in eros.",
                    Version = 3.17
                },
                new JsonDataUser {
                    Name = "Antía Sixirei",
                    Language = "Galician",
                    Id = "XOF91ZR7MHV1TXRS",
                    Bio = "Pellentesque massa sem, scelerisque sit amet odio id, cursus tempor urna. Phasellus massa ligula, hendrerit eget efficitur eget, tincidunt in ligula. Morbi finibus dui sed est fringilla ornare. Duis pellentesque ultrices convallis. Morbi ultricies consequat ligula posuere eleifend.",
                    Version = 6.44
                },
                new JsonDataUser {
                    Name = "Aygul Mutellip",
                    Language = "Uyghur",
                    Id = "FTSNV411G5MKLPDT",
                    Bio = "Duis commodo orci ut dolor iaculis facilisis. Nam semper gravida nunc, sit amet elementum ipsum. Donec pellentesque ultrices mi, non consectetur eros luctus non. Pellentesque massa sem, scelerisque sit amet odio id, cursus tempor urna.",
                    Version = 9.1
                },
                new JsonDataUser {
                    Name = "Awais Shaikh",
                    Language = "Sindhi",
                    Id = "OJMWMEEQWMLDU29P",
                    Bio = "Nunc aliquet sodales nunc a pulvinar. Ut dictum, ligula eget sagittis maximus, tellus mi varius ex, a accumsan justo tellus vitae leo. Donec pellentesque ultrices mi, non consectetur eros luctus non. Nulla finibus massa at viverra facilisis. Nunc tincidunt laoreet laoreet.",
                    Version = 1.59
                }
                ];
            return data;
        }
        public Task<List<JsonDataUser>> GetAll(int page, int length)
        {
           var data = Data();

            return Task.FromResult(data);
        }
    }
}
