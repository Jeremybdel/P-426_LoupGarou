------------------Installer Git Bash------------------

Pour installer Git en bash vous pouvez :

	1. T�l�charger sur le web --> https://github.com/git-for-windows/git/releases/download/v2.25.0.windows.1/Git-2.25.0-64-bit.exe
	
	2. Copie du fichier .exe de git dan le K:\ --> K:\INF\Maitres-Eleves\Outils\Git\06-Git

Une fen�tre d'installation s'ouvrira --> cliquez sur "next"

Si vous ne voulez pas changer le chemin d'installation du l'appli  --> Cliquez sur "next"

Ensuite une fen�tre affiche les diff�rents modules qui vont �tre install� (modifie si vous vous s'y connaissez en github) sinon --> Cliquez sur "next"

Ensuite cliquez sur "next" pour les 6 pages suivantes


------------------Configuration de git------------------

Une fois install�, il faut taper cette commande --> git --version , elle vous affiche la version de votre git

Ensuite il faut inscrire votre nom d'utilisateur, votre email :

nom d'utilisateur --> git config --global user.name "YOUR_USERNAME"
Email		  --> git config --global user.email "your_email_address@example.com"

Pour afficher vos info --> git config --global --list

 

POUR INTIALISER UN DIRECTORY LOCAL (intialise le controle de version pour le clone local du rep Git)

tapez --> git init


------------------Cloner un repo------------------

Tout d'abord, il faut cr�er une cl� HTTPS

	
	------------------Cl� HTTPS------------------
	
  	Il suffit de copier le liens du repo GitHub 
	
	Sur le repo Github.com --> bouton "clone et download" --> v�rifez que vous �tes bien sur "Clone with HTTPS"


tapez dans le bash : https://github.com/votrepseudo/nomdugit.git 


------------------ATTENTION !!------------------

� chaque fois que vous devez pull ou push dans le git cloner avec HTTPS, vous devez rentrer vos indentifiants Github !s

