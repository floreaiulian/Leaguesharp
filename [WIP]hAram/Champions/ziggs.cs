﻿using LeagueSharp;
using LeagueSharp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hAram.Champions
{
    class ziggs : Base
    {

        public ziggs()
        {
            Game.PrintChat("hAram : " + Player.ChampionName + "Loaded.");
        }

        public override void Game_OnUpdate(EventArgs args)
        {
            base.Game_OnUpdate(args);



            CastSpell(Q, qData);
            CastSpell(E, eData);

            var closetTarget = getObject.ClosetHero();

            if (Player.Distance(closetTarget) <= 250)
            {
                if (W.Instance.ToggleState == 1)
                    W.Cast(Player.Position);
            }

            if (W.Instance.ToggleState != 1)
                W.Cast();

            target = GetTarget(R);

            if (target != null && R.Instance.ToggleState == 1)
            {
                CastSpell(R, rData);
            }
            else if (target == null && R.Instance.ToggleState != 1)
            {
                CastSpell(R, rData);
            }
        }
    }
}
