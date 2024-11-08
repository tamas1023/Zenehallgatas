using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zenehallgatas
{
    internal static class Program
    {

        public static Form searchForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form search = new Search();
            searchForm = search;
            Application.Run(search);
            


            //kell 2 form, 1 a böngészésre , és 1 az új zene felvételre, és módosításra
            /*
             LEÍRÁS:
            Kötelező program
            Kötelező feladat
            .NET Core 5.0+, vagy .NET FW 4.8+ alapú projektet kell készíteni. Követni kell az MVC tervezési mintát.
            Pontozás:
            - MVC tervezési minta használata: 20 pont
            - helyes adatbázis kezelés: 20 pont
            - Winforms: 30 pont
            - ASP.NET MVC: 30 pont
            Beadás:
            - Az elkészült feladatot be kell tömöríteni és elérhető kell tenni (javasolt a coospace feladatok közé feltölteni): **NEPTUN_ID.zip**
            - Beadási határidő 2024. december 4. 16:00. (mivel később lett kihirdetve a kötelező program plusz 2 óra áll rendelkezésre)
            - Törlendő elemek: A `bin` és `obj` mappák.
            - Az alábbi két feladat közül az egyik választhatóű

            Feladatok
            # 01 - Zenehallgatás
            * Egy zenével kapcsolatos alkalmazásának elkészítése C# nyelven, mely követi az MVC modellt
            * Az adatok SQLite adatbázisban tárolandók.
            * Az adatbázis sémáját `zenelista.sql` kell tartalmaznia.

            Az alkalmazásnak a következő funkcionalitásokat kell támogatnia.

            Egy menüsor segítségével lehessen választani a funkcionalitások között.
            ** Új zene hozzáadása
            Zene a következő tulajdonságokkal bír:

             | Név | Típus | További információ |

            |------|-------|-------|

            | Cím | szöveg | nem üres, egyedi |

            | Előadó | szöveg | nem üres |

            | Kiadás éve | szám | pozitív |

            | Zene hossza | szám | pozitív |

            | Prioriás | szám | pozitív - ennyire szeretnéd meghallgatni |

             Egy új zene hozzáadása esetén a kapott értékeket tárolni kell az adatbázisban.


            ** Böngészés

            * A meghallgatandó zenékek lehet listázni, viszont a prioritás ne látszódjon, de érték szerint legyen rendezve a lista (magasabb szám elöl).
            * A lista egy DataGridView-be jelenjen meg.


            ** Zene módosítása


            * A listában egy zenére kattintva módosítható legyen.

              * A "zene felvétele" Form-ot használva.

              * A DataGridView-ban ne lehessen össze-vissza átírni az értékeket.

            * Módosítható elem: prioritás.

            WinFormsban megvalósítandó funkciók:

            ** Új zene hozzáadása

            ** Böngészés

            ** Zene módosítása

            ASP.NET MVC-ben megvalósítandó funkció

            ** Új zene hozzáadása

            ** Böngészés
             
             */
        }
    }
}
