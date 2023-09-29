using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CharacterSheet))]
public class CharacterSheetEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        CharacterSheet characterSheet = (CharacterSheet)target;

        int strengthMod = 0;
        int speedMod = 0;
        int rangeMod = 0;
        int healthMod = 0;

        switch (characterSheet.characterClass)
        {
            case CharacterClass.Archer:
                strengthMod = -2;
                rangeMod = 2;
                characterSheet.CharacterSprite = Resources.Load<Sprite>("ArcherSprite");
                break;
            case CharacterClass.Warrior:
                strengthMod = 2;
                speedMod = -2;
                characterSheet.CharacterSprite = Resources.Load<Sprite>("WarriorSprite");
                break;
            case CharacterClass.Wizard:
                strengthMod = -2;
                speedMod = 2;
                characterSheet.CharacterSprite = Resources.Load<Sprite>("WizardSprite");
                break;
            default:
                break;
        }

        characterSheet.Strength = int.Parse(characterSheet.characterBaseStats.Strength.ToString()) + strengthMod;
        characterSheet.Speed = int.Parse(characterSheet.characterBaseStats.Speed.ToString()) + speedMod;
        characterSheet.Range = int.Parse(characterSheet.characterBaseStats.Range.ToString()) + rangeMod;
        characterSheet.Health = int.Parse(characterSheet.characterBaseStats.Health.ToString()) + healthMod;
    }
}
