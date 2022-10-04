using EFCoreTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorial.Test
{
    public class TestSong1
    {
        [Fact]
        void Create_Increases_Count()
        {
            var db = new MusicContext();
            var underTest = new SongRepository(db);

            underTest.Create(new Song() { Title = "Foo" });

            var count = underTest.Count();
            Assert.Equal(0, count);
        }
    }
}
