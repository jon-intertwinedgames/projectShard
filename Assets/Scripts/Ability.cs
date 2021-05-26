using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class Ability : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;
    //public Sprite slotArtwork;

    public int cooldown;

    public List<Energy> cost = new List<Energy>();
    public List<Effect> effects = new List<Effect>();

    /*Additional Attributes to add later:
     *    Ability Type (Instant, Secret)
     *    AudioSource
     * */

    /* Possible Methods
        public void castAbility()
          {

          }

        public void uncastAbility()
          {

          }

        public void executeAbility()
          {

          }
    */
}
