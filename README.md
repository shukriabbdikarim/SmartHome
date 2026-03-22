Systemdiagram
![SmartHome Diagram](images/diagram.png)

# SmartHomeSmartHome (.NET)
Ett C#-projekt som simulerar ett smart hem med flera designmönster.

 Funktioner
Styr en lampa
Olika lägen (Normal, Eco, Party)
Command system (TurnOn)
Observer system (Dashboard, Audit, Logger)
Undo & Replay

 Designmönster
Facade – SmartHomeFacade
Observer – Dashboard, Audit, Logger
Command – ICommand, TurnOnCommand
Strategy – NormalMode, EcoMode, PartyMode

 Kör projektet
Öppna i Visual Studio
Tryck F5

 Struktur
Commands/
Core/
Devices/
Facade/
Observers/
Strategy/

Författare
Shukri Abdikarim