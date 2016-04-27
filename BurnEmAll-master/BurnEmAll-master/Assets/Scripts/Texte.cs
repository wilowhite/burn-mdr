using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Texte : MonoBehaviour {
    int n = 0;
    Text texte;
    // Use this for initialization
    void Start() {
		texte = GetComponent<Text>();
		//     string message; et message = texte.text;
    }

    void Update()
    {
    if(Input.GetMouseButtonDown(0)) {
            n = n+1;
            Debug.Log(n);
               switch(n) {
                case 1:
				    texte.text = "Il n'y a pas si longtemps que ça \n ni très très loin non plus  \n un homme se réveillait en pleine nature  ";
                    break;
                case 2:
				    texte.text = "Celui-ci ne savait pas ce qu'il faisait ici \n En plus il était nue ! Mais sa c'est une autre histoire";
                    break;
                case 3:
				    texte.text = "Alors qu'il reprenait ces esprits \n ceux-ci ce mirent à lui parler \n Ces voix tantôt douce tantôt puissante";
                    break;
                case 4:
				    texte.text = " l'incitait à faire du mal à la nature autour de lui \n Il trouva une torche face à lui";
                    break;
                case 5:
				    texte.text = "La flamme lui parla, le réchauffa, le réconforta  \n mais l'entraina par la même occassion dans la folie\n";
                    break;
                case 6:
				    texte.text = "La natura lui sembla alors hostile \n Les lapin eurent tout à coup les yeux luisant \n il pouvait voir des visages sur les fleurs";
                    break;
			    case 7:
				    texte.text = "Les canards volaient et pondaient des oeufs en même temps \n Tout ces animaux voulait sa mort";
				    break;
			    case 8:
				    texte.text = "Il avait sombré dans la folie ! \n Mais ne l'était-il pas déjà avant ? \n out ce qu'il savait, c'est que la réponse se tennait entre ses mains. ";
				    break;
			    case 9:
				texte.text = "Il comprit vite que le feu était l'unique solution à tout ces problèmes.\n Toutes les voix se mirent à chuchoter, murmurer, parler, crier, hurler la même chose ";
				    break;			
                 case 10:
				    texte.text = "BURM'EM ALL.";
                    texte.fontSize = 45;
                    break;
                case 11:
					SceneManager.LoadScene ("Level1");
                    break;
            }
    }
    }
}
