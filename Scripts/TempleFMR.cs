// Project:         FindingMyReligion for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2022 Hazelnut
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Hazelnut

using DaggerfallConnect.Arena2;
using System.Collections.Generic;

namespace DaggerfallWorkshop.Game.Guilds
{
    public class TempleFMR : Temple
    {
        protected static TextFile.Token newLine = TextFile.CreateFormatToken(TextFile.Formatting.JustifyCenter);

        public TempleFMR(Divines deity) : base(deity)
        {
        }

        public override bool CanRest()
        {
            return IsMember();
        }

        public override TextFile.Token[] TokensWelcome()
        {
            List<TextFile.Token> welcome = new List<TextFile.Token>(base.TokensWelcome());

            welcome.Add(newLine);
            welcome.Add(TextFile.CreateTextToken("Please feel free to make use of the beds"));
            welcome.Add(newLine);
            welcome.Add(TextFile.CreateTextToken("for your rest and comfort. Your well-being is"));
            welcome.Add(newLine);
            welcome.Add(TextFile.CreateTextToken("important to us. Before I let you go, read the"));
            welcome.Add(newLine);
            welcome.Add(TextFile.CreateTextToken("your deity's mantra on the statue. Recite it"));
            welcome.Add(newLine);
            welcome.Add(TextFile.CreateTextToken("every morning and before resting."));
            welcome.Add(newLine);            
            return welcome.ToArray();
        }
    }
}