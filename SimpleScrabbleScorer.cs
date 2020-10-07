// This is a simple word scorer for a scrabble-like game.  It does not have 
// a board so all scores are based only on the word and its length.
// The rules are as follows:
// 1. Letters are worth the same as in scrabble
// 2. Each instance of a doubled letter (e.g. the o's in food) is worth 3 extra
// points
// 3. If the word has 5 or 6 characters, double the final score, if it has 7 or
// 8, triple the final score, if it has 9 or more, quadrouple it

public class SimpleScrabbleScorer {
    public static void Main(string[] args) {
        Word NewScrabbleWord = new Word(args[0]);
        System.Console.WriteLine(NewScrabbleWord.CalculateScore());
    }
}

public class Word
{
    public string Value;
    public char[] Letters;

    public Word(string word)
    {
        this.Value = Word;
        this.Letters = Word.ToCharArray();
    }

    private int CalculateScore()
    {
        int CurrentScore = 0;
        CurrentScore += GetLetterPoints();
        CurrentScore *= GetMultiplier();
      
        if (BonusPoints() == true) 
          	CurrentScore += 3;

        return CurrentScore;
    }

    private int GetLetterPoints()
    {
        int score = 0;
        foreach (char letter in this.Letters) {
            switch (letter) {
		        case 'a':
		        case 'e':
		        case 'o':
		        case 's':
			        score += 1;
        			break;
        		case 'c':
        		case 'f':
        		case 'g':
        		case 'i':
        		case 'l':
        		case 'r':
        		case 't':
        		case 'u':
                case 'd':
        			score += 2;
        			break;
        		case 'h':
        		case 'k':
        		case 'm':
        		case 'n':
        			score += 3;
        			break;
        		case 'j':
        		case 'p':
        		case 'w':
        		case 'y':
        			score += 5;
        			break;
        		case 'q':
        			score += 7;
        			break;
        		case 'v':
        		case 'z':
        			score += 8;
        			break;
      		}
    	}
   		return score;
  	}

  	private bool BonusPoints()
  	{
	    for (int i = 0; i <= this.Letters.Length; i++)
		    if (i != 0)
	        	if (Letters[i - 1] == Letters[i])
			        return true;
    	return false;
  	}
  
  	private int GetMultiplier() {
  		if (Letters.Length <= 4)
      		return 1;
    	else if (Letters.Length <= 6)
      		return 2;
      	else if (Letters.Length <= 9)
      		return 3;
      	else
      		return 4;
	}
}
