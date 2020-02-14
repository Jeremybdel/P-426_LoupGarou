/*
 * ETML
 * 
 * Auteurs : Théo Brunner
 *           Daniel Gil
 *           Tristan Gerber
 *           Ismael Giovanetti
 *           Arthur Menétrey
 *           Tiago Costa Ferreira di paula di josé di chatale
 *           Jeremy Delisle
 *           
 * Date : 14.01.2020 - 25.02.2020
 * 
 * Description : Le but de ce programme est de reconstituer le jeu de carte du loup-garou. 
 *               Le jeu pourra être joué en multijoueur sur différents ordinateurs.
 */
//using System.Windows.Media.Imaging;

namespace Werewolf.Resources
{
    public abstract class Card
    {
        public string Name { get; private set; }
        public int Priority { get; private set; }
        /*public Library.Orientations Orientation { get; private set; }
        public BitmapImage Image { get; private set; }
        public BitmapImage BackImage { get; private set; }*/

        public Card(string name, int priority/*, Library.Orientations orientation, BitmapImage image = null*/)
        {
            Name = name;
            Priority = priority;
            /*this.Orientation = orientation;
            this.Image = image;*/
        }

        public abstract void WakeUpNight();

        public void WakeUpMorning()
        {

        }

        public virtual void Die()
        {

        }
    }
}
