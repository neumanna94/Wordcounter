# _{Wordcounter}_

#### _{User enters a sentence/paragraph and a word that should be counted.}, {2/16/17}_

#### By _**{Alexander Neumann @ Epicodus}**_

## Description

_{This web "application" takes user input from a form and makes a post request to transfer the user input to a RepeatCounter Model. The repeatcounter model breaks the users sentence input into a list Splitted by spaces. Then finds the number of elements in the list with the same string as the input word.}_

## Setup/Installation Requirements

* _Clone from Github_
* _While in the cloned project path execute dotnet run_

## Known Bugs

_{None currently known of.}_

## Support and contact details

_{alexander.daniel.neumann@gmail.com}_

## Technologies Used

_{HTML, CSS, C#, ASP.NET MVC 1.1.3,Unit Testing}_

## _{Specifications}_
## Class Name: RepeatCounter(inputSentence)
_{Properties: string sentence, string word, int wordCount}_
_{Methods: Getters, Setters, WordCount(), WordCount(string oneWord)}_

##Method Name: GetWord(),GetSentence(),GetWordCount()
_{Input:}_
_{Output: The respective property of the current RepeatCounter object}_
_{Overview: Used for the html page to generate content based on form inputs.}_

##Method Name: SetWord(),SetSentence()
_{Input: string(SetWord, SetSentence)}_
_{Output: void_
_{Overview: Used to set the properties of the given RepeatCounter object.}_

## Method Name: RepeatCounter.WordCount()
_{Input:}_
_{Output: int total number of counts of oneWord in sentence.}_
_{Overview: Will convert string to a List based on spaces and then convert everything to lowercase. Will then look for how many time word == sentence[i]. Accounting for commas, periods, questionmarks, exclamation marks. }_

## Method Name: RepeatCounter.Splitter()
_{Input:}_
_{Output: A list of _sentence split indexed by spaces where each element is converted to LowerCase.}_
_{Overview: Will be used wth WordCount to count the number of times a word is in a sentence.}

### License

*{MIT}*

Copyright (c) 2018 **_{Alexander Neumann @ Epicodus}_**
