using System;

public class NAW
{
	public NAW()
	{
        naam = "";
        adres = "";
        woonplaats = "";
	}

    public NAW(string initialNaam, string initialAdres, string initialWoonplaats)
    {
        naam = initialNaam;
        adres = initialAdres;
        woonplaats = initialWoonplaats;
    }

    private String naam;
    public String Naam
    {
        get
        {
            return naam;
        }
        set
        {
            if ((value != null) && (value.Length >0))
            {
                naam = value;
            }
            else
            {

            }
        }
    }

    private string adres;
    public string Adres
    {
        get
        {
            return adres;
        }
        set
        {
            adres = value;
        }
    }

    private string woonplaats;
    public string Woonplaats
    {
        get
        {
            return woonplaats;
        }
        set
        {
            woonplaats = value;
        }
    }

    public bool HeeftNaam(string gezochteNaam)
    {
        return this.naam.Equals(gezochteNaam, StringComparison.Ordinal);
    }

    public bool HeeftAdres(string gezochteAdres)
    {
        return this.adres.Equals(gezochteAdres, StringComparison.Ordinal);
    }

    public bool HeeftWoonplaats(string gezochteWoonplaats)
    {
        return this.woonplaats.Equals(gezochteWoonplaats, StringComparison.Ordinal);
    }

    public void Show()
    {
        System.Console.WriteLine("NAW: naam={0} adres={1} woonplaats={2}", Naam, Adres, Woonplaats);
    }

    public int CompareTo(NAW andereNaw)
    {
        if ((andereNaw.Naam == Naam) && (andereNaw.Adres == Adres) && (andereNaw.Woonplaats == Woonplaats))
        {
            return 0;
        }
        else
        {
            if (!(andereNaw.Woonplaats == Woonplaats))
            { // woonplaatsen zijn verschillend
                return Woonplaats.CompareTo(andereNaw.Woonplaats);
            }
            else if (!(andereNaw.Naam == Naam))
            { // woonplaatsen zijn verschillend en namen zijn verschillend
                return Naam.CompareTo(andereNaw.Naam);
            }
            else
            { // woonplaatsen en namen zijn gelijk
                return Adres.CompareTo(andereNaw.Adres);
            }
        }
    }
}
