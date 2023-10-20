using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MierdonArtista.Game;

namespace MierdonArtista
{
    public void Main(string[] args)
    {
        MyGame game = new MyGame();
        UDK.Game.Launch(game);
    }
}
