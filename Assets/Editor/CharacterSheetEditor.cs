using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CharacterSheet))]
public class CharacterSheetEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        CharacterSheet characterSheet = (CharacterSheet)target;

        switch (characterSheet.characterClass)
        {
            case CharacterClass.Archer:
                characterSheet.Strength = int.Parse(characterSheet.characterBaseStats.Strength.ToString()) - 2;
                characterSheet.Damage = int.Parse(characterSheet.characterBaseStats.Damage.ToString());
                characterSheet.Speed = int.Parse(characterSheet.characterBaseStats.Speed.ToString());
                characterSheet.Vision = int.Parse(characterSheet.characterBaseStats.Vision.ToString());
                characterSheet.Range = int.Parse(characterSheet.characterBaseStats.Range.ToString()) + 2;
                characterSheet.Health = int.Parse(characterSheet.characterBaseStats.Health.ToString());
                break;
            case CharacterClass.Warrior:
                characterSheet.Strength = int.Parse(characterSheet.characterBaseStats.Strength.ToString()) + 2;
                characterSheet.Damage = int.Parse(characterSheet.characterBaseStats.Damage.ToString());
                characterSheet.Speed = int.Parse(characterSheet.characterBaseStats.Speed.ToString()) - 2;
                characterSheet.Vision = int.Parse(characterSheet.characterBaseStats.Vision.ToString());
                characterSheet.Range = int.Parse(characterSheet.characterBaseStats.Range.ToString());
                characterSheet.Health = int.Parse(characterSheet.characterBaseStats.Health.ToString());
                break;
            case CharacterClass.Wizard:
                characterSheet.Strength = int.Parse(characterSheet.characterBaseStats.Strength.ToString());
                characterSheet.Damage = int.Parse(characterSheet.characterBaseStats.Damage.ToString()) - 2;
                characterSheet.Speed = int.Parse(characterSheet.characterBaseStats.Speed.ToString());
                characterSheet.Vision = int.Parse(characterSheet.characterBaseStats.Vision.ToString()) + 2;
                characterSheet.Range = int.Parse(characterSheet.characterBaseStats.Range.ToString());
                characterSheet.Health = int.Parse(characterSheet.characterBaseStats.Health.ToString());
                break;
            default:
                break;
        }
    }
}
