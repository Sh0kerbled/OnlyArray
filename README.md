# Firtering an array
## Desription

**The array creation**  
   I have created an initial array containing the names of programming languages:
   
   ```csharp
string[] array = { "Java", "C++", "Python", "C#", "JavaScript", "Go" };
```
this task was interested me, beacuse finally i began to understand how works loop with commas.

then i created loop for and added verify if word has only three or less words
first loop checks every word in array
   ```csharp
for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }
```

## Mistake with new array
```csharp
string[] newArray = {};
```
then i created  new null array(that was mistake)
after searching error reasons i asked chatgpt why it doesnt work
this ai showed me why i need to add new string[array.Length]

and the last loop i remooved checker from main array.
this checker outputs the code and adding in parallel commas
 ```csharp
for (int i = 0; i < index; i++)
            {
                if(i < index - 1)
                {
                    Console.Write($"{newArray[i]}, ");
                }
                else
                {
                    Console.Write(newArray[i]);
                }
            }
```
