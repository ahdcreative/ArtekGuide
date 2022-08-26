namespace ArtekGuide.UI.Components.Duty;

using ArtekGuide.UI.Components;
using System;
using System.Linq;
using ImGuiNET;
using ArtekGuide.Types;

/// <summary>
///     A component for displaying duty information.
/// </summary>
static class DutyInfoComponent
{
    /// <summary> 
    ///     Draws the duty info window.
    /// </summary>
    /// <param name="duty"> The duty to draw information for. </param>
    public static void Draw(Duty duty)
    {
        try
        {
            DutyHeadingComponent.Draw(duty);

            if (ImGui.BeginTabBar("#Bosses", ImGuiTabBarFlags.FittingPolicyScroll | ImGuiTabBarFlags.TabListPopupButton | ImGuiTabBarFlags.NoTabListScrollingButtons))
            {
                foreach (var boss in duty.Bosses ?? Enumerable.Empty<Duty.Boss>())
                {
                    if (ImGui.BeginTabItem(boss.Name))
                    {
                        DutyBossComponent.Draw(boss);
                        ImGui.EndTabItem();
                    }
                }
                ImGui.EndTabBar();
            }
        }
        catch (Exception e) { ImGui.TextColored(Colours.Error, $"Component Exception: {e.Message}"); }
    }
}