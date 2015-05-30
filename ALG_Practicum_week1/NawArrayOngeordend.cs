using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_Practicum_week1
{
    public class NawArrayOngeordendOutOfBoundsException : Exception
    {
        public NawArrayOngeordendOutOfBoundsException()
        {
        }

    }

    public class NawArrayOngeordendInvalidSizeException : Exception
    {
        public NawArrayOngeordendInvalidSizeException()
        {
        }

    }

    public class NawArrayOngeordend
    {
        private NAW[] nawArray;

        private int size;

        private int used;

        public NawArrayOngeordend()
        {
            size = 20;
            nawArray = new NAW[size];
        }
        public NawArrayOngeordend(int initialSize)
        {
            // testcases:
            // -bij onjuiste initialSize <1 of > 100000 moet exception gegooid worden

             if ((initialSize > 0) && (initialSize < 1000000))
                {
                    size = initialSize;
              }
                else
                {
                    throw new NawArrayOngeordendInvalidSizeException();
                }

            nawArray = new NAW[size];
        }

        public int Count()
        {
            return used;
        }

        public void VoegToe(NAW item)
        {
            // Test cases:
            // -Er moeten net zoveel items toegevoegd kunnen worden als de opgegeven omvang bij creatie
            // -Bij het toevoegen aan volle array moet exceptie komen
            // -toevoegen van item mag eerdere items niet overschrijven
            // -toevoegen van item moet aan einde van array gebeuren i.v.m. efficientie

            if (used < size)
            {
                nawArray[used++] = item;
            }
            else
            {
                throw new NawArrayOngeordendOutOfBoundsException();
            }
        }

        public int ZoekNaam(string gezochteNaam)
        {
            for (int i=0; i<used;i++)
            {
                if (nawArray[i].Naam.Equals(gezochteNaam,StringComparison.Ordinal))
                {
                    return i;
                }
            }

            return -1;
        }

        public int ZoekAdres(string gezochteAdres)
        {
            for (int i = 0; i < used; i++)
            {
                if (nawArray[i].Adres.Equals(gezochteAdres, StringComparison.Ordinal))
                {
                    return i;
                }
            }

            return -1;
        }

        public int ZoekWoonplaats(string gezochteWoonplaats)
        {
            for (int i = 0; i < used; i++)
            {
                if (nawArray[i].Woonplaats.Equals(gezochteWoonplaats, StringComparison.Ordinal))
                {
                    return i;
                }
            }

            return -1;
        }

        public int ZoekAdresEnWoonplaats(string gezochteAdres,string gezochteWoonplaats)
        {
            for (int i = 0; i < used; i++)
            {
                if ( (nawArray[i].Adres.Equals(gezochteAdres, StringComparison.Ordinal)) && (nawArray[i].Woonplaats.Equals(gezochteWoonplaats, StringComparison.Ordinal)) )
                {
                    return i;
                }
            }

            return -1;
        }

        public void Show()
        {
            System.Console.WriteLine("Array contains {0} of {1} items.",used,size);
            for (int i=0; i<size; i++)
            {
                if (i == used)
                {
                    System.Console.WriteLine("------------------------------------------------------");
                }
                System.Console.Write("Item {0} contains: ", i);
                if (nawArray[i] != null)
                {
                    nawArray[i].Show();
                }
                else
                {
                    System.Console.WriteLine("nothing");
                }
            }
        }

        public void VerwijderIndex(int index)
        {
            // testcases:
            // -aantal gebruikte elementen is nu eentje minder
            // -object op index kan na verwijdering niet meer in array gevonden worden
            // -array is na verwijdering aaneengesloten
            // -er worden niet onnodig veel elementen gekopieerd bij het 'aanschuiven'

            used--;

            for (int i=index;i<used;i++)
            {
                nawArray[i] = nawArray[i + 1];
            }
            
        }

        
        public void VerwijderEersteMetNaam(string gezochteNaam)
        {
            for (int i = 0; i < used; i++)
            {
                if (nawArray[i].Naam.Equals(gezochteNaam, StringComparison.Ordinal))
                {
                    VerwijderIndex(i);
                    return;
                }
            }
        }

        public void VerwijderLaatsteMetNaam(string gezochteNaam)
        {
            for (int i = (used-1); i>=0; i--)
            {
                if (nawArray[i].Naam.Equals(gezochteNaam, StringComparison.Ordinal))
                {
                    VerwijderIndex(i);
                    return;
                }
            }
        }

        public int VerwijderAlleMetNaam(string gezochteNaam)
        {
            int aantalVerwijderd = 0;
            for (int i=0; i<used; i++)
            {
                if (nawArray[i].Naam.Equals(gezochteNaam, StringComparison.Ordinal))
                {
                    VerwijderIndex(i);
                    aantalVerwijderd++;
                }
            }

            return aantalVerwijderd;
        }
    }
}
