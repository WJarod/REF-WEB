# REF_WEB_LOGICIEL :

***

## Description :

L'obectif est de réaliser une application de prise de RDV qui sera lié à un calendrier qui va générer un planning contenant des tâches en fonction de la demande du client, de la Dead Line, du niveau des développeurs et de leurs disponibilités.
L’objectif réel est d’automatisé tout ce processus de gestion de projets, de tâches et de personnel.

Exemple : 

Un planning est généré avec des tâches issues d’un projet.
Les tâches ont un niveau de difficulté et une spécification qui correspond à un temps imparti.
Les tâches seront affiliées à un utilisateur (ex : développeur ) qui lui aussi aura une spécialisation et un niveau de compétence.
Il faudra automatiser le fait qu’une tâche soit affiliée à un utilisateur en fonction de son niveau et de sa spécialisation.
Cependant si un utilisateur correspondant à une tâche n’est pas disponible, il faudra l’affilier à un autre utilisateur qui aura peut-être moins de compétence et dans une autre spécialisation, cela voudra dire que le temps imparti de la tâche sera multiplié/divisé en fonction de la difficulté de la tâche et du niveau ainsi que de la spécialisation du développeur.

Par exemple un développeur de niveau 1 avec une spécialisation Front qui est affilié à une tache de niveau 4 avec une spé Front mettra 4 fois plus de temps qu’un utilisateur de niveau 4.
Et inversement un développeur de niveau 4 affilié à une tâche de niveau 1 sera 4 fois plus productif donc on divisera le temps de la tâche.

Pareillement pour les spécialisations si un développeur Front est affilié à une tâche Back il mettra 2, voir 3 fois plus de temps qu’un développeur Back.

***

### Dépendance :

* C#
* Installer [.Net 5](https://dotnet.microsoft.com/download/dotnet/5.0)

***

### Commande pour lancer L'app :

* Comment run l'app

* Avec le terminal VS Code
```
dotnet run
```
* Racourcis VS Code
```
ctrl + f5
```
***

### Structure :
![Notre Structure micro-service](https://i.ibb.co/MGmqP78/Screenshot-1.png)
![La Structure d'un micro-service]()
***

### Liens utile :

* Aidez-vous avec la documentation [.Net 5](https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio-code)
* Aidez-vous avec la documentation [C#](https://docs.microsoft.com/fr-fr/dotnet/csharp/)
* Aidez-vous avec la documentation [MongoDB](https://www.mongodb.com/cloud/atlas/lp/try2?utm_source=google&utm_campaign=gs_emea_france_search_core_brand_atlas_desktop&utm_term=mongodb&utm_medium=cpc_paid_search&utm_ad=e&utm_ad_campaign_id=12212624521&adgroup=115749705063)
* Aidez-vous avec la documentation [Kubernetes](https://kubernetes.io/fr/)
* Aidez-vous avec la documentation [RabbitMQ](https://www.rabbitmq.com/)

ceci est un test