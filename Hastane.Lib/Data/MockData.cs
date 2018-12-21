using Hastane.Lib.Models;

namespace Hastane.Lib.Data
{
    public class MockData
    {
        public Context context { get; set; }
        public MockData()
        {
            context = new Context();
            for (int i = 0; i < 10; i++)
            {
                context.Hastalar.Add(new Hasta()
                {
                    Ad=FakeData.NameData.GetFirstName(),
                    Soyad=FakeData.NameData.GetSurname(),
                    DogumTarihi=FakeData.DateTimeData.GetDatetime(),
                    TCKN=FakeData.TextData.GetNumeric(11),
                    Telefon="5"+FakeData.TextData.GetNumeric(9)

                });
            }
            for (int i = 0; i < 10; i++)
            {
                context.Doktorlar.Add(new Doktor()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    Maas=FakeData.NumberData.GetNumber(4000,10000),
                    Servis=FakeData.EnumData.GetElement<Servis>()

                });
            }
            for (int i = 0; i < 10; i++)
            {
                context.Hemsireler.Add(new Hemsire()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    Maas = FakeData.NumberData.GetNumber(3000,7000),
                    Servis = FakeData.EnumData.GetElement<Servis>()

                });
            }
        }
    }
}
