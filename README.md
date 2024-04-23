# Jumpter-assignment-MauroSterckx
## Namen
- Enrique Bataire (2ITSOF)
- Mauro Sterckx (2ITCSC1)
##
## Tutorial
1. Start een unity scene
2. Plaats een 'plane', dit is de vloer
3. Plaats een 'cube', dit is de jumper
4. Plaats een andere 'cube', dit wordt de balk, dupliceer deze en plaats deze ergens anders indien gewenst

5. Geef de objecten kleuren indien je dit wenst

### Scaling
6. Pas de scaling van de 'plane' aan naar: X2, Y2, Z5
7. Pas de scaling van de balk aan naar: X13, Y1, Z1

### Import ML Package
8. Open de Unity Package manager (window > package manager)
9. Klik linksboven op de Packages en zorg dat je 'In Registery' hebt geselecteerd, zie foto <br>
   ![image](https://github.com/AP-IT-GH/jumper-assignment-BotzzMonkey31/blob/master/src/image.png)
10. Selecteer en installeer de ML agents package

### Jumper setup
11. Zorg voor de volgende parameters voor de jumper: <br>
![image](https://github.com/AP-IT-GH/jumper-assignment-BotzzMonkey31/blob/master/src/img2.png)

<br>

![img3](https://github.com/AP-IT-GH/jumper-assignment-BotzzMonkey31/blob/master/src/img3.png)

### Jumper script
12. Clone het jumperscript vanuit dit project en plaats het in je unity project folder
13. Clone de configfile vanuit dit project en plaats dit in de folder 'config'
14. Zorg voor de volgende parameters
<br>

![img4](https://github.com/AP-IT-GH/jumper-assignment-BotzzMonkey31/blob/master/src/img4.png)


### Resultaten
![img](https://github.com/AP-IT-GH/jumper-assignment-BotzzMonkey31/blob/master/src/tensor.png)
<br>
De "Environment/Cumulative Reward" grafiek toont een stijgende trend in beloningen naarmate het model leert. De grafiek stabiliseert rond 400.000 epochs, wat suggereert dat het model een niveau van expertise heeft bereikt waarop verdere verbetering minder frequent voorkomt. <br> Waarschijnlijk is dit omdat het model geen reden meer heeft om te verbeteren aangezien het tegen dan elke epoch overleeft.


### Anaconda
14. Open je Anaconda environment 
15. cd naar je projectfolder
16. Plak dit commando: ```mlagents-learn Config/CubeAgent.yaml --run-id=CubeAgent --resume``` in de terminal
17. Navigeer terug naar unity en druk Play, nu zou de jumper moeten jumpen over de obstacels
