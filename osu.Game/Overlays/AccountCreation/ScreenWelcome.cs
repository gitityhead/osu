// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Graphics.Sprites;
using osu.Game.Overlays.Settings;
using osu.Game.Screens.Menu;
using osuTK;

namespace osu.Game.Overlays.AccountCreation
{
    public class ScreenWelcome : AccountCreationScreen
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            Child = new FillFlowContainer
            {
                RelativeSizeAxes = Axes.Both,
                Direction = FillDirection.Vertical,
                Anchor = Anchor.TopCentre,
                Origin = Anchor.TopCentre,
                Padding = new MarginPadding(20),
                Spacing = new Vector2(0, 5),
                Children = new Drawable[]
                {
                    new OsuLogo
                    {
                        Scale = new Vector2(0.1f),
                        Margin = new MarginPadding { Vertical = 500 },
                        Anchor = Anchor.TopCentre,
                        Origin = Anchor.TopCentre,
                        Triangles = false,
                        BeatMatching = false,
                    },
                    new OsuSpriteText
                    {
                        TextSize = 24,
                        Font = "Exo2.0-Light",
                        Anchor = Anchor.TopCentre,
                        Origin = Anchor.TopCentre,
                        Text = "New Player Registration",
                    },
                    new OsuSpriteText
                    {
                        TextSize = 12,
                        Anchor = Anchor.TopCentre,
                        Origin = Anchor.TopCentre,
                        Text = "let's get you started",
                    },
                    new SettingsButton
                    {
                        Text = "Let's create an account!",
                        Margin = new MarginPadding { Vertical = 120 },
                        Action = () => Push(new ScreenWarning())
                    }
                }
            };
        }
    }
}
