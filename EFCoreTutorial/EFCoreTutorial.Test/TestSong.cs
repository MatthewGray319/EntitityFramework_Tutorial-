using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorial.Test
{
    public class TestSong
    {
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var db = new MusicContext();
            var underTest = new SongRepository(db);

            var count = underTest.Count();

            Assert.Equal(3, count);
        }
    }
}
