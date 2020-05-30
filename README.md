# Project Querimonia
A few years ago I have heard about an "exploit" in almost all TeamSpeak3-Servers, which is possible by default: Complaint Autobanning.
This Bot will utilize this "Exploit" to systematically autoban Users on a given Server to expose this vulnerability to the respective Server-Operators.

# How to shield yourself
There are several, very easy ways to counter an Complaint-Autoban (CAB):
<ul>
  <li> Change the virtualserver_complain_autoban_count to an insanely high amount, e.g. 9999. (to be found in Edit Virtual Server>MISC in TS3-GUI)</li>
  <li> Revoke the i_client_complain_power from Non-Admin Users or try to stage Servergroups into e.g. <i>newly joined, regular, veteran</i>. Setting a high value for i_client_needed_complain_power is also possible.</li>
</ul>

# Features
<ul>
  <li> Collective Nickname Acquisition on every Server it connects to, in order to produce real Usernames. (Disguisal of malicious intent)</li>
  <li> Bots will join in random intervals and switch to one or more empty channels if possible.</li>
  <li> Probe for Rights: Does CAB even work?, Switch Channel, Create Channel. This happens before other Bots join the server.</li>
  <li> Probe for Servergroups: Returns a list of Online Servergroups and prompts the User before executing CAB.</li>
</ul>

# Used Libraries
<ul>
  <li><a href="https://teamspeak.com/en/downloads/#sdk">The official TeamSpeak3-SDK</a></li>
