# Configuration

## UserToken

1. Login to Discord on any browser
2. Open Developer Tools in browser by pressing Ctrl-Shift-I or F12 (depending of broswer)
3. Find somethig called console in the Developer Tools
4. type : 
```
document.body.appendChild(document.createElement`iframe`).contentWindow.localStorage.token
```
you should get a long string within quotes, like :""longtext"" . 
This is your user token

#config.json (copy an example file and edit the new file)

1. replace USERTOKEN with your user token found above. Make sure that you have only quote character and beginnng and at the end. 
2. adjust servers and rooms as you need. One server and room is checked by default, only for responses in specific string
3. If you adding a new server/room or you would like to change parser, make sure you know how to handle regular expressions... :) 
4. Adjust filters. The first filter from the list (per channe) , that is met  - wins

# (Optional) How to prepare parsing regular expressions

1. Find a Discord server and channel in it, that you want to have monitored
2. Find a example message (but repeteable), that contains Pokemon Name , coordinates. (nothing else is used by this crawler)
3. Prepare a regular expression string. 
4. Paste the string to the config

For example for channel "100playground" on server "Pokedex100" the example text is:
>Exeggutor 84IV 40.013137,-75.106145 818CP L10 Zen Headbutt/Psychic

To parse it with Regular Expression, the below regular expression pattern can be used:
>(?<name>[^\\s]+)\\s(?<IV>[^IV]+)IV\\s(?<latitude>[^,]+),(?<longtitude>[^\\s]+) 

It will produce below groups:
name: Exeggutor
IV: 84
latitude: 40.013137
longtitude: -75.106145

So to make sure that your regular expresison pattern is valid, you could use this website: http://regexstorm.net/tester 
In the Pattern , put the pattern
In Input put the row from channel which containt Pokemon information , that you want to use
To test, check Table tab below Input field. 


# Usage
````
cd DiscordCrawler
dotnet restore 
dotnet run
````

>dotnet restore is needed only before 1st run

Enjoy!
