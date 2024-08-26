# Rebelia Ronin

![GameName](https://user-images.githubusercontent.com/42646031/151656394-9755f47b-04e7-4923-ac37-58f2bd688dea.png)

Hra vypráví příběh o bezejmenném hrdinovi, který má za úkol zneškodnit systém Sibyl, který byl vybodován na podporu lidstva. Aby pomáhal s každodeními úkoly ale nějak se to zvrtlo... - [Úvod](#Intro)

Hra obsahuje prvky FPS hry s inspirací Já, Robot, COD a WoW prvků -  [Bližší info tu](#Popis)

Tento projekt byl vyvýjen na verzi UE4.18 s Blueprinty (visuální scriptování) a byl obhájen na známku 2

🎓 Maturitní projekt
Tato hra byla navržena a vyvinuta v rámci maturitní práce, s cílem prokázat dovednosti v oblasti herního vývoje, grafického designu a programování. Zaměřuje se na technické aspekty herního vývoje i kreativní návrh herního prostředí.

🛠️ Funkcionalita hry
- Střelba: Pro lepší míření stiskni pravé tlačítko myši
- Systém questů: Jak jinak vyprávět přéběh?
- One Shoot one kill no luck all skill: Bosové tě zabijou na jednu ránu a ani nevíš odkud ti jedna přiletí

🎮 Jak hrát?
- Pohyb: WSAD střelba LMB a míření RMB
- Interakce: E nebo LMB
- Quest Log: Stiskni TABulátor

🛠️ Použité technologie
- Programovací / Scriptovací jazyk: Blueprint
- Grafika: Virtus, Mixamo, Grafická práce <a href="https://www.linkedin.com/in/sabina-malenov%C3%A1/" alt="LinkedInSabčaMalenova">Sabiny Malenové</a>
- Herní engine: Unreal Engine 4.18


## Intro

Lidé zlenivěli, vytvořili stroje, aby jim pomohli vpráci, ale to bylo málo, a tak naučili stroje vytvářet další stroje. A to byl pouze začátek. Potom jim svěřili ochranu přírody, letectví a za pár let i bezpečnost. Senátoři uklidňovali prostý lid, že je to tak bezpečné. Za několik dekád obyvatel Země se zredukoval o setiny procent. Za století to již byla polovina celé Země. Roboti redukovali obyvatelé několika způsoby, hlavně pro výzkum a vývoj. Lidé měli schopnost přirozené reakce, kterou roboti mohli stěží simulovat,a tak je drželi vtáborech, mnoho znich se ale mučení nedožilo, zemřeli na následek nedostatku potravin a pitné vody. Ti,co přežili, by si přáli, aby zemřeli. Pro-váděli na nich výzkum přirozené reakce. Dokonce je i svařovali a dávali si otázky, proč to nejde svařit?proč to teče? co je to? ...

Byla to léta ještě před vzpourou, ale někdo se „prokecl“. Roboti je našli dříve, než to  mohlo  vypuknout.  Nicméně  pár  lidí  se  dohodlo  mezi  sebou  a  vyvolali  první vzpouru. Kdy roboti neznali pojem rychlo−pulzní zbraň. Stalo se to, že po vzpouře si roboti uvědomili, jak jsou zranitelní a jeden znich si vzal zbraň a vystřelil, lidé se dali na útěk, Sibyl vydala rozkaz, aby si vzali zbraň, roboti poslechli, vzali zbraně... stří-leli. Násilí utichlo, až se přeživší schovali do hor. Po několika letech, kdy našli staré zásoby zbraní zdob, kdy pouze lidé zabíjeli lidé. A losovalo se, kdo půjde sejmout ty bastardy. „Los vyšel na tebe, tak jdi...“.

## Popis

### Systém questů

Systém questů je nepovinný, inspirace byla ze hry World of Warcraft. Jako programový jazyk byl zde využit BluePrint. NCP postavy byly již součástí enginu, jako je manekýn. 
Pokud si odmyslíte barvu. Nebo jsou součástí Esset free, které Epic Games nabízí zdarma kvyužití spolu s animacemi. Ve projektu byly využity assety právě kombinací manekýna, free assetů (těch permanentních) a free mounth assetů, které Epic Games nabízí každý měsíc.
Tento systém funguje tak, že přijdeteza NCP, objeví se hláška, že máte stisknout „E“ pro interakci, po stisku tlačítka se objeví menší okno Objectives, který Vám řekne, co je to za quest (jak se jmenuje, jaký jsou požadavky na splnění,co je potřeba udělat).

![image](https://user-images.githubusercontent.com/42646031/111865608-604a0580-8968-11eb-8baf-44053518792d.png)

Hráč má na výběr, zdali příjme quest anebo odmítne. Pokud hráč quest příjme, po stisku klávesy „Q“ se mu objeví Quest Log. Musí se stisknout na tlačítko myší, aby se aktivoval aktivní quest. Pokud odmítne, nic se neděje.

Quest Log je dělen na Story Quest a Side Quest. Vedle ve sloupci je text, který se objevil již vObjectives.Zároveň se na hlavní obrazovce zobrazí oranžovou barvou, co je potřeba udělat a zdalije quest splněn.

Quest log v editoru.

![image](https://user-images.githubusercontent.com/42646031/111865627-748e0280-8968-11eb-8deb-c69487506b18.png)

Jak vypadá Quest log ve hře.

![image](https://user-images.githubusercontent.com/42646031/111865636-7c4da700-8968-11eb-89c2-bc952bb0df5c.png)

První NPC se kterém se dá interagovat je Wolfer, ten zadá i první úkol a to ten, zajít do tabora a promluvit si s Murdockem. 

![image](https://user-images.githubusercontent.com/42646031/111865643-853e7880-8968-11eb-9018-80c850f3379f.png)

NPC Murdock, ten je spolu s Wraitem v Hlavním táboře.

![image](https://user-images.githubusercontent.com/42646031/111865649-8bccf000-8968-11eb-9cbb-9185b3fadef6.png)

NPC Wrait dá doplňkový úkol.

![image](https://user-images.githubusercontent.com/42646031/111865655-94252b00-8968-11eb-9824-edfef7b591c7.png)


Patrola, ta je tam aby demonstrovala volný pohyb po videoherním plánu.

![image](https://user-images.githubusercontent.com/42646031/111865666-9b4c3900-8968-11eb-9a36-b1826f3e49cb.png)



### Bosové

#### Samurai

Ve hře se vyskytují dva bossové, a jsou to: Samurai:Humanoid, který slouží Sibyl. Ve hře je to paragon Kwang. 
Má několik útoků mečem, který je náhodný, leč vražedný, zabije Vás na jednu ránu.

![image](https://user-images.githubusercontent.com/42646031/111865496-a18de580-8967-11eb-99fe-a19c86ce1e26.png)

![image](https://user-images.githubusercontent.com/42646031/111865500-aeaad480-8967-11eb-9409-84fc774d4ed8.png)


#### Sibyl

Robotická inteligence, která hráče zabije opětna jednu ránu. Má zatím jeden útok. Ve hře je Sibyl paragon Muriel.

![image](https://user-images.githubusercontent.com/42646031/111865518-d601a180-8967-11eb-99d1-1bc95dc89587.png)

![image](https://user-images.githubusercontent.com/42646031/111865521-ddc14600-8967-11eb-8a8a-674a774f8889.png)



### Hlavní menu & Pause menu

Po intru, které je součástí hry, se hráč objeví vhlavním menu, kde je na výběr. „New Game“, „Options“, „Quit game“. Kde při výběru Options, si může upravit rozlišení. Hudba v Hlavním menu je od interpreta The Enigma TNG, a nese název: Xaeta-coreHudba vPause menu je od stejného interpreta, a nese název: The Falling Star

![image](https://user-images.githubusercontent.com/42646031/111865457-5a075980-8967-11eb-8ca4-cf77402fc45d.png)

Po stisknutí klávesy „ESC“ se objeví Pause menu, které pozastaví časomíru, která je vidět na levém horním rohu, zároveň umožní přechod do hlavního menu, pro případ odchodu předčasně ze hry.

![image](https://user-images.githubusercontent.com/42646031/111865414-16aceb00-8967-11eb-9844-be28d3d5700c.png)


### Leading, Death Win screens

Loading screen slouží ktomu, aby se zaplnilo černé místo mezi přestupy mezi levely hry. Zároveň je zde i možnost vidět UDMG, které je hojně používáno právě na tyto obrázky, kvůlidynamice.

![image](https://user-images.githubusercontent.com/42646031/111865283-6dfe8b80-8966-11eb-8b64-d78660e67e6d.png)

Dead screen, byl inspirován hrami Left 4 Dead, Dark souls.

![image](https://user-images.githubusercontent.com/42646031/111865288-7bb41100-8966-11eb-8a03-f1a88369459f.png)

Tento Win screen je výsledek práce ve Photoshopod Adobe. A autorem tohoto obrázku je Sabina Malenová.

![image](https://user-images.githubusercontent.com/42646031/111865294-84a4e280-8966-11eb-85f0-2eef90fa9e2a.png)

### FPS prvky
Hra je vžánru FPS, Firstperson shooter a má následují prvky:
- Přebíjení zbraní
- Switch zbraní
- Střelba
- Míření
- Health bar
- Armor bar
- SWAT character
- AK –47
- A1M4Assety  mají  svého  majitele,  kterým  je  Virtus  Studios,  2017  [online].  
[cit. 09.09.2018] Dostupnéz:https://drive.google.com/file/d/1TEHLeQG094UkoPOU-gxlPx52ObJysXx23/view
