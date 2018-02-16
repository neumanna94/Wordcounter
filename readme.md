# _{Wordcounter}_

#### _{User enters a sentence/paragraph and a word that should be counted.}, {2/16/17}_

#### By _**{Alexander Neumann @ Epicodus}**_

## Description

_{}_

## Setup/Installation Requirements

* _Clone from Github_
* _While in the cloned project path execute dotnet run_

## Known Bugs

_{}_

## Support and contact details

_{alexander.daniel.neumann@gmail.com}_

## Technologies Used

_{HTML, CSS, C#, ASP.NET MVC 1.1.3,Unit Testing}_

### License

*{MIT}*

Copyright (c) 2018 **_{Alexander Neumann @ Epicodus}_**

_{Specifications}_
## Class Name: RepeatCounter(inputSentence)
_{Properties: string sentence, string word, int wordCount}_
_{Methods: Properties getter and setters. WordCount(), WordCount(string oneWord)}_
## Method Name: RepeatCounter.WordCount()
_{Input:}_
_{Output: int total number of counts of oneWord in sentence.}_
_{Overview: Will convert string to a List based on spaces and then convert everything to lowercase. Will then look for how many time word == sentence[i]. Accounting for commas, periods, questionmarks, exclamation marks. }_

## Method Name: RepeatCounter.Splitter()
_{Input:}_
_{Output: A list of _sentence split indexed by spaces where each element is converted to LowerCase.}_
_{Overview: Will be used wth WordCount to count the number of times a word is in a sentence.}
