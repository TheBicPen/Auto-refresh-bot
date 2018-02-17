# Auto-refresh-bot

A bot that loads a certain page in a webbrowser, and reloads it after a specified interval.

The original purpose of this bot is quite unethical: there exist some websites that control votes through an AJAX control.
By navigating to the AJAX control's URL, a vote is automatically submitted without any action from the user.
The URL can be found by running a network analysis through a proper browser's developer tools.
