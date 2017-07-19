using System;
using Newtonsoft.Json.Linq;

namespace Credence
{
    public class JSONTrivia
    {
        public static JObject m = JObject.Parse(@"{
	            'results':
                [
                    {
                        'category': 'Entertainment: Music',
                        'type': 'multiple',
                        'difficulty': 'medium',
                        'question': 'Who is the artist of the recent new album the Uncanny Valley?',
                        'correct_answer': 'Perturbator',
                        'incorrect_answers': [
                        'Carpenter Brut',
                        'GOST',
                        'Dan Terminus '
                        ]
                    },
                    {
                        'category': 'Entertainment: Music',
                        'type': 'multiple',
                        'difficulty': 'easy',
                        'question': 'In the Rossini opera, what was the name of \'The Barber of Seville\'?',
                        'correct_answer': 'Figaro',
                        'incorrect_answers': [
                        'Angelo',
                        'Fernando',
                        'Dave'
                        ]
                    },
                    {
                        'category': 'Animals',
                        'type': 'boolean',
                        'difficulty': 'easy',
                        'question': 'Kangaroos keep food in their pouches next to their children.',
                        'correct_answer': 'False',
                        'incorrect_answers': [
                        'True'
                        ]
                    },
                    {
	                    'category': 'Entertainment: Video Games',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'When was the Sega Genesis released in Japan?',
	                    'correct_answer': 'October 29, 1988',
	                    'incorrect_answers': [
		                    'August 14, 1989',
		                    'November 30, 1990',
		                    'September 1, 1986'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Film',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Which animated movie was first to feature a celebrity as a voice actor?',
	                    'correct_answer': 'Aladdin',
	                    'incorrect_answers': [
		                    'Toy Story',
		                    'James and the Giant Peach',
		                    'The Hunchback of Notre Dame'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Music',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'Which American family band had a 1986 top 10 hit with the song \'Crush On You\'?',
	                    'correct_answer': 'The Jets',
	                    'incorrect_answers': [
		                    'DeBarge',
		                    'The Jacksons',
		                    'The Cover Girls'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Film',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Who wrote and directed the 1986 film \'Platoon\'?',
	                    'correct_answer': 'Oliver Stone',
	                    'incorrect_answers': [
		                    'Francis Ford Coppola',
		                    'Stanley Kubrick',
		                    'Michael Cimino'
	                    ]
                    },
                    {
	                    'category': 'Celebrities',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Named after a character he played in a 1969 film, what is the name of the ski resort in Utah that Robert Redford bought in 1968?',
	                    'correct_answer': 'Sundance',
	                    'incorrect_answers': [
		                    'Woodward',
		                    'Turner',
		                    'Booker'
	                    ]
                    },
                    {
	                    'category': 'Science: Computers',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'Moore\'s law originally stated that the number of transistors on a microprocessor chip would double every...',
	                    'correct_answer': 'Year',
	                    'incorrect_answers': [
		                    'Four Years',
		                    'Two Years',
		                    'Eight Years'
	                    ]
                    },
                    {
	                    'category': 'Geography',
	                    'type': 'boolean',
	                    'difficulty': 'medium',
	                    'question': 'The surface area of Russia is slightly larger than that of the dwarf planet Pluto.',
	                    'correct_answer': 'True',
	                    'incorrect_answers': [
		                    'False'
	                    ]
                    },
                    {
	                    'category': 'Geography',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Which country does Austria not border?',
	                    'correct_answer': 'France',
	                    'incorrect_answers': [
		                    'Slovenia',
		                    'Switzerland',
		                    'Slovakia'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Television',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Grant Gustin plays which superhero on the CW show of the same name?',
	                    'correct_answer': 'The Flash',
	                    'incorrect_answers': [
		                    'The Arrow',
		                    'Black Canary',
		                    'Daredevil'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Video Games',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'If a \'360 no-scope\' is one full rotation before shooting, how many rotations would a \'1080 no-scope\' be?',
	                    'correct_answer': '3',
	                    'incorrect_answers': [
		                    '4',
		                    '2',
		                    '5'
	                    ]
                    },
                    {
	                    'category': 'General Knowledge',
	                    'type': 'boolean',
	                    'difficulty': 'medium',
	                    'question': 'The vapor produced by e-cigarettes is actually water.',
	                    'correct_answer': 'False',
	                    'incorrect_answers': [
		                    'True'
	                    ]
                    },
                    {
	                    'category': 'History',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'Which infamous European traitor was known as \'the last person to enter Parliament with honest intentions\'?',
	                    'correct_answer': 'Guy Fawkes',
	                    'incorrect_answers': [
		                    'Robert Catesby',
		                    'Francis Tresham',
		                    'Everard Digby'
	                    ]
                    },
                    {
	                    'category': 'General Knowledge',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Which one of the following rhythm games was made by Harmonix?',
	                    'correct_answer': 'Rock Band',
	                    'incorrect_answers': [
		                    'Meat Beat Mania',
		                    'Guitar Hero Live',
		                    'Dance Dance Revolution'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Video Games',
	                    'type': 'boolean',
	                    'difficulty': 'easy',
	                    'question': 'There are 6 legendary cards in \'Clash Royale\'.',
	                    'correct_answer': 'False',
	                    'incorrect_answers': [
		                    'True'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Japanese Anime & Manga',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'In the anime series \'Full Metal Alchemist\', what do Alchemists consider the greatest taboo?',
	                    'correct_answer': 'Human Transmutation ',
	                    'incorrect_answers': [
		                    'Transmuting Lead Into Gold',
		                    'Using Alchemy For Crime ',
		                    'Preforming Without A Permit'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Japanese Anime & Manga',
	                    'type': 'boolean',
	                    'difficulty': 'medium',
	                    'question': 'The animated film \'Spirited Away\' won the Academy Award for Best Animated Feature at the 75th Academy Awards in 2003.',
	                    'correct_answer': 'True',
	                    'incorrect_answers': [
		                    'False'
	                    ]
                    },
                    {
	                    'category': 'General Knowledge',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'Which of the following is not another name for the eggplant?',
	                    'correct_answer': 'Potimarron',
	                    'incorrect_answers': [
		                    'Brinjal',
		                    'Guinea Squash',
		                    'Melongene'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Video Games',
	                    'type': 'boolean',
	                    'difficulty': 'medium',
	                    'question': 'Metal Gear Solid V: The Phantom Pain runs on the Fox Engine.',
	                    'correct_answer': 'True',
	                    'incorrect_answers': [
		                    'False'
	                    ]
                    },
                    {
	                    'category': 'Science & Nature',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'What was the name of the first artificial Earth satellite, launched by the Soviet Union in 1957?',
	                    'correct_answer': 'Sputnik 1',
	                    'incorrect_answers': [
		                    'Soyuz 7K-OK',
		                    'Zenit-2',
		                    'Voskhod 3KV'
	                    ]
                    },
                    {
	                    'category': 'Science: Computers',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'The internet domain .fm is the country-code top-level domain for which Pacific Ocean island nation?',
	                    'correct_answer': 'Micronesia',
	                    'incorrect_answers': [
		                    'Fiji',
		                    'Tuvalu',
		                    'Marshall Islands'
	                    ]
                    },
                    {
	                    'category': 'General Knowledge',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'What was the destination of the missing flight MH370?',
	                    'correct_answer': 'Beijing',
	                    'incorrect_answers': [
		                    'Kuala Lumpur',
		                    'Singapore',
		                    'Tokyo'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Video Games',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'In the 2002 video game \'Kingdom Hearts\', how many playable worlds were there?',
	                    'correct_answer': '14',
	                    'incorrect_answers': [
		                    '13',
		                    '16',
		                    '11'
	                    ]
                    },
                    {
	                    'category': 'General Knowledge',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'The Swedish word \'Grunka\' means what in English?',
	                    'correct_answer': 'Thing',
	                    'incorrect_answers': [
		                    'People',
		                    'Place',
		                    'Pineapple'
	                    ]
                    },
                    {
	                    'category': 'Geography',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'How many countries does Spain have a land border with?',
	                    'correct_answer': '5',
	                    'incorrect_answers': [
		                    '2',
		                    '3',
		                    '4'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Film',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'In 2012, which movie won every category in the 32nd \'Golden Raspberry Awards\'?',
	                    'correct_answer': 'Jack and Jill',
	                    'incorrect_answers': [
		                    'The Girl with the Dragon Tattoo',
		                    'Thor',
		                    'The King\'s Speech'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Film',
	                    'type': 'boolean',
	                    'difficulty': 'easy',
	                    'question': 'Shaquille O\'Neal appeared in the 1997 film \'Space Jam\'.',
	                    'correct_answer': 'False',
	                    'incorrect_answers': [
		                    'True'
	                    ]
                    },
                    {
	                    'category': 'History',
	                    'type': 'boolean',
	                    'difficulty': 'medium',
	                    'question': 'If you grab the bladed end of a longsword in a specific way, you will not cut yourself.',
	                    'correct_answer': 'True',
	                    'incorrect_answers': [
		                    'False'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Japanese Anime & Manga',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'Which one of these Manga titles was not created by Urasawa Naoki?',
	                    'correct_answer': 'My Father\'s Journal',
	                    'incorrect_answers': [
		                    'Billy Bat',
		                    '20th Century Boys',
		                    'Monster'
	                    ]
                    },
                    {
	                    'category': 'Politics',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'Which letter do you need to have on a European driver license in order to ride any motorbikes?',
	                    'correct_answer': 'A',
	                    'incorrect_answers': [
		                    'X',
		                    'D',
		                    'B'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Japanese Anime & Manga',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Who is the main character with yellow hair in the anime Naruto?',
	                    'correct_answer': 'Naruto',
	                    'incorrect_answers': [
		                    'Ten Ten',
		                    'Sasuke',
		                    'Kakashi'
	                    ]
                    },
                    {
	                    'category': 'Vehicles',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Automobiles produced by Telsa Motors operate on which form of energy?',
	                    'correct_answer': 'Electricity',
	                    'incorrect_answers': [
		                    'Gasoline',
		                    'Diesel',
		                    'Nuclear'
	                    ]
                    },
                    {
	                    'category': 'Sports',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'Which car company is the only Japanese company which won the 24 Hours of Le Mans?',
	                    'correct_answer': 'Mazda',
	                    'incorrect_answers': [
		                    'Toyota',
		                    'Subaru',
		                    'Nissan'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Japanese Anime & Manga',
	                    'type': 'boolean',
	                    'difficulty': 'easy',
	                    'question': 'In the \'Melancholy of Haruhi Suzumiya\' series, the narrator goes by the nickname Kyon.',
	                    'correct_answer': 'True',
	                    'incorrect_answers': [
		                    'False'
	                    ]
                    },
                    {
	                    'category': 'Mythology',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Which Greek & Roman god was known as the god of music, truth and prophecy, healing, the sun and light, plague, poetry, and more?',
	                    'correct_answer': 'Apollo',
	                    'incorrect_answers': [
		                    'Aphrodite',
		                    'Artemis',
		                    'Athena'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Video Games',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'Which was the first M-rated video game developed by Squaresoft/Square Enix?',
	                    'correct_answer': 'Parasite Eve',
	                    'incorrect_answers': [
		                    'Final Fantasy VIII',
		                    'Front Mission',
		                    'Vagrant Story'
	                    ]
                    },
                    {
	                    'category': 'Geography',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'Which country was NOT formerly part of Yugoslavia?',
	                    'correct_answer': 'Albania',
	                    'incorrect_answers': [
		                    'Croatia',
		                    'Serbia',
		                    'Macedonia'
	                    ]
                    },
                    {
	                    'category': 'Geography',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'What tiny principality lies between Spain and France?',
	                    'correct_answer': 'Andorra',
	                    'incorrect_answers': [
		                    'Liechtenstein',
		                    'Monaco',
		                    'San Marino'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Television',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'In the Netflix show, Stranger Things, what song would Will sing to himself as he was missing?',
	                    'correct_answer': 'Should I Stay or Should I Go?',
	                    'incorrect_answers': [
		                    'Love Will Tear Us Apart',
		                    'This Charming Man',
		                    'Africa'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Books',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'The title of Adolf Hitler\'s autobiography \'Mein Kampf\' is what when translated to English?',
	                    'correct_answer': 'My Struggle',
	                    'incorrect_answers': [
		                    'My Hatred',
		                    'My Sadness',
		                    'My Desire'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Video Games',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'In Super Mario Bros., who informs Mario that the princess is in another castle?',
	                    'correct_answer': 'Toad',
	                    'incorrect_answers': [
		                    'Luigi',
		                    'Yoshi',
		                    'Bowser'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Film',
	                    'type': 'boolean',
	                    'difficulty': 'medium',
	                    'question': 'Sean Connery wasn\'t in \'Indiana Jones and the Kingdom of the Crystal Skull\' because he found retirement too enjoyable.',
	                    'correct_answer': 'True',
	                    'incorrect_answers': [
		                    'False'
	                    ]
                    },
                    {
	                    'category': 'History',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'The Battle of Hastings was fought in which year?',
	                    'correct_answer': '1066',
	                    'incorrect_answers': [
		                    '911',
		                    '1204',
		                    '1420'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Books',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'The book \'The Silence of the Lambs\' gets its title from what?',
	                    'correct_answer': 'The main character\'s trauma in childhood',
	                    'incorrect_answers': [
		                    'The relation it has with killing the innocents',
		                    'The villain\'s favourite meal',
		                    'The voice of innocent people being shut by the powerful'
	                    ]
                    },
                    {
	                    'category': 'Geography',
	                    'type': 'boolean',
	                    'difficulty': 'medium',
	                    'question': 'Liechtenstein does not have an airport.',
	                    'correct_answer': 'True',
	                    'incorrect_answers': [
		                    'False'
	                    ]
                    },
                    {
	                    'category': 'Entertainment: Music',
	                    'type': 'boolean',
	                    'difficulty': 'hard',
	                    'question': 'The band STRFKR was also briefly known as Pyramiddd.',
	                    'correct_answer': 'True',
	                    'incorrect_answers': [
		                    'False'
	                    ]
                    },
                    {
	                    'category': 'Sports',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'Which of the following Grand Slam tennis tournaments occurs LAST?',
	                    'correct_answer': 'US Open',
	                    'incorrect_answers': [
		                    'French Open',
		                    'Wimbledon',
		                    'Australian Open'
	                    ]
                    },
                    {
	                    'category': 'Science: Computers',
	                    'type': 'multiple',
	                    'difficulty': 'medium',
	                    'question': 'What does the term GPU stand for?',
	                    'correct_answer': 'Graphics Processing Unit',
	                    'incorrect_answers': [
		                    'Gaming Processor Unit',
		                    'Graphite Producing Unit',
		                    'Graphical Proprietary Unit'
	                    ]
                    },
                    {
	                    'category': 'Animals',
	                    'type': 'boolean',
	                    'difficulty': 'easy',
	                    'question': 'Cats have whiskers under their legs.',
	                    'correct_answer': 'True',
	                    'incorrect_answers': [
		                    'False'
	                    ]
                    },
                    {
	                    'category': 'Science: Computers',
	                    'type': 'multiple',
	                    'difficulty': 'hard',
	                    'question': 'Which of these is not a key value of Agile software development?',
	                    'correct_answer': 'Comprehensive documentation',
	                    'incorrect_answers': [
		                    'Individuals and interactions',
		                    'Customer collaboration',
		                    'Responding to change'
	                    ]
                    },
                    {
	                    'category': 'History',
	                    'type': 'multiple',
	                    'difficulty': 'easy',
	                    'question': 'Who was among those killed in the 2010 Smolensk, Russia plane crash tragedy?',
	                    'correct_answer': 'The Polish President',
	                    'incorrect_answers': [
		                    'Pope John Paul II',
		                    'Bang-Ding Ow',
		                    'Albert Putin'
	                    ]
                    },
				    {
					    'category': 'Entertainment: Video Games',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'What\'s the name of the main protagonist in the \'Legend of Zelda\' franchise?',
					    'correct_answer': 'Link',
					    'incorrect_answers': [
						    'Mario',
						    'Zelda',
						    'Pit'
					    ]
				    },
				    {
					    'category': 'Vehicles',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'Where are the cars of the brand \'Ferrari\' manufactured?',
					    'correct_answer': 'Italy',
					    'incorrect_answers': [
						    'Romania',
						    'Germany',
						    'Russia'
					    ]
				    },
				    {
					    'category': 'Sports',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'Which of the following sports is not part of the triathlon?',
					    'correct_answer': 'Horse-Riding',
					    'incorrect_answers': [
						    'Cycling',
						    'Swimming',
						    'Running'
					    ]
				    },
				    {
					    'category': 'Animals',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'A carnivorous animal eats flesh, what does a nucivorous animal eat?',
					    'correct_answer': 'Nuts',
					    'incorrect_answers': [
						    'Nothing',
						    'Fruit',
						    'Seaweed'
					    ]
				    },
				    {
					    'category': 'General Knowledge',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'According to the BBPA, what is the most common pub name in the UK?',
					    'correct_answer': 'Red Lion',
					    'incorrect_answers': [
						    'Royal Oak',
						    'White Hart',
						    'King\'s Head'
					    ]
				    },
				    {
					    'category': 'Science: Mathematics',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'What is the derivative of Acceleration with respect to time?',
					    'correct_answer': 'Jerk',
					    'incorrect_answers': [
						    'Shift',
						    'Bump',
						    'Slide'
					    ]
				    },
				    {
					    'category': 'Entertainment: Film',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'Who played the female lead in the 1933 film \'King Kong\'?',
					    'correct_answer': 'Fay Wray',
					    'incorrect_answers': [
						    'Jean Harlow',
						    'Vivien Leigh',
						    'Mae West'
					    ]
				    },
				    {
					    'category': 'Entertainment: Musicals & Theatres',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'Which Shakespeare play inspired the musical \'West Side Story\'?',
					    'correct_answer': 'Romeo & Juliet',
					    'incorrect_answers': [
						    'Hamlet',
						    'Macbeth',
						    'Othello'
					    ]
				    },
				    {
					    'category': 'General Knowledge',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'What does a funambulist walk on?',
					    'correct_answer': 'A Tight Rope',
					    'incorrect_answers': [
						    'Broken Glass',
						    'Balls',
						    'The Moon'
					    ]
				    },
				    {
					    'category': 'Entertainment: Film',
					    'type': 'boolean',
					    'difficulty': 'easy',
					    'question': 'The movie \'The Nightmare before Christmas\' was all done with physical objects.',
					    'correct_answer': 'True',
					    'incorrect_answers': [
						    'False'
					    ]
				    },
				    {
					    'category': 'Entertainment: Music',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Which of these is NOT an album released by The Beatles?',
					    'correct_answer': 'The Wall',
					    'incorrect_answers': [
						    'Abbey Road',
						    'Magical Mystery Tour',
						    'Revolver'
					    ]
				    },
				    {
					    'category': 'General Knowledge',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Rolex is a company that specializes in what type of product?',
					    'correct_answer': 'Watches',
					    'incorrect_answers': [
						    'Cars',
						    'Computers',
						    'Sports equipment'
					    ]
				    },
				    {
					    'category': 'Entertainment: Music',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'Which singer was featured in Jack Ü (Skrillex & Diplo)\'s 2015 song \'Where Are Ü Now\'?',
					    'correct_answer': 'Justin Bieber',
					    'incorrect_answers': [
						    'Selena Gomez',
						    'Ellie Goulding',
						    'The Weeknd'
					    ]
				    },
				    {
					    'category': 'Entertainment: Video Games',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'Which franchise does the creature \'Slowpoke\' originate from?',
					    'correct_answer': 'Pokemon',
					    'incorrect_answers': [
						    'Dragon Ball',
						    'Sonic The Hedgehog',
						    'Yugioh'
					    ]
				    },
				    {
					    'category': 'Politics',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Who was the only president to not be in office in Washington D.C?',
					    'correct_answer': 'George Washington',
					    'incorrect_answers': [
						    'Abraham Lincoln',
						    'Richard Nixon',
						    'Thomas Jefferson'
					    ]
				    },
				    {
					    'category': 'Entertainment: Board Games',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'On a standard Monopoly board, which square is diagonally opposite \'Go\'? ',
					    'correct_answer': 'Free Parking',
					    'incorrect_answers': [
						    'Go to Jail',
						    'Jail',
						    'The Electric Company'
					    ]
				    },
				    {
					    'category': 'History',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Which country had an \'Orange Revolution\' between 2004 and 2005?',
					    'correct_answer': 'Ukraine',
					    'incorrect_answers': [
						    'Belarus',
						    'Latvia',
						    'Lithuania'
					    ]
				    },
				    {
					    'category': 'Geography',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Kuala Lumpur is the capital of which country?',
					    'correct_answer': 'Malaysia',
					    'incorrect_answers': [
						    'Indonesia',
						    'Singapore',
						    'Thailand'
					    ]
				    },
				    {
					    'category': 'Science: Computers',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'If you were to code software in this language you\'d only be able to type 0\'s and 1\'s.',
					    'correct_answer': 'Binary',
					    'incorrect_answers': [
						    'JavaScript',
						    'C++',
						    'Python'
					    ]
				    },
				    {
					    'category': 'Science: Computers',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'What was the first commerically available computer processor?',
					    'correct_answer': 'Intel 4004',
					    'incorrect_answers': [
						    'Intel 486SX',
						    'TMS 1000',
						    'AMD AM386'
					    ]
				    },
				    {
					    'category': 'General Knowledge',
					    'type': 'boolean',
					    'difficulty': 'easy',
					    'question': 'Nutella is produced by the German company Ferrero.',
					    'correct_answer': 'False',
					    'incorrect_answers': [
						    'True'
					    ]
				    },
				    {
					    'category': 'Entertainment: Video Games',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'What was the first \'Team Fortress 2\' update to include a war?',
					    'correct_answer': 'Sniper vs. Spy Update',
					    'incorrect_answers': [
						    'WAR! Update',
						    'Meet Your Match Update',
						    'Spy Vs. Engineer Update'
					    ]
				    },
				    {
					    'category': 'General Knowledge',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'What is a \'dakimakura\'?',
					    'correct_answer': 'A body pillow',
					    'incorrect_answers': [
						    'A Chinese meal, essentially composed of fish',
						    'A yoga posture',
						    'A word used to describe two people who truly love each other'
					    ]
				    },
				    {
					    'category': 'Entertainment: Music',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'How many members are there in the idol group \'μ\'s\'?',
					    'correct_answer': '9',
					    'incorrect_answers': [
						    '48',
						    '6',
						    '3'
					    ]
				    },
				    {
					    'category': 'Entertainment: Japanese Anime & Manga',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'In the anime series \'Full Metal Alchemist\', what do Alchemists consider the greatest taboo?',
					    'correct_answer': 'Human Transmutation ',
					    'incorrect_answers': [
						    'Transmuting Lead Into Gold',
						    'Using Alchemy For Crime ',
						    'Preforming Without A Permit'
					    ]
				    },
				    {
					    'category': 'Entertainment: Music',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Madonna\'s song \'Hung Up\' includes a piece from which popular 70s song?',
					    'correct_answer': 'Gimmie! Gimmie! Gimme! (A Man After Midnight)',
					    'incorrect_answers': [
						    'Staying Alive',
						    'Night Fever',
						    'The Chain'
					    ]
				    },
				    {
					    'category': 'General Knowledge',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'After how many years would you celebrate your crystal anniversary?',
					    'correct_answer': '15',
					    'incorrect_answers': [
						    '20',
						    '10',
						    '25'
					    ]
				    },
				    {
					    'category': 'Entertainment: Japanese Anime & Manga',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'When was the first episode of Soul Eater released?',
					    'correct_answer': '2008',
					    'incorrect_answers': [
						    '2003',
						    '2005',
						    '2011'
					    ]
				    },
				    {
					    'category': 'Entertainment: Music',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Which of these is NOT the name of an album released by American rapper Viper?',
					    'correct_answer': 'The Life of Pablo',
					    'incorrect_answers': [
						    'Kill Urself My Man',
						    'You\'ll Cowards Don\'t Even Smoke Crack',
						    'Yo Wife Handcuffin\' Me'
					    ]
				    },
				    {
					    'category': 'Science: Computers',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'The internet domain .fm is the country-code top-level domain for which Pacific Ocean island nation?',
					    'correct_answer': 'Micronesia',
					    'incorrect_answers': [
						    'Fiji',
						    'Tuvalu',
						    'Marshall Islands'
					    ]
				    },
				    {
					    'category': 'Entertainment: Film',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'What did the first moving picture depict?',
					    'correct_answer': 'A galloping horse',
					    'incorrect_answers': [
						    'A woman in a dress',
						    'A man walking',
						    'A crackling fire'
					    ]
				    },
				    {
					    'category': 'Entertainment: Film',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Who plays the Nemesis in the Resident Evil movies?',
					    'correct_answer': 'Matthew Taylor',
					    'incorrect_answers': [
						    'Jason Dip',
						    'Eric Mabius',
						    'Jimmy Matts'
					    ]
				    },
				    {
					    'category': 'Entertainment: Video Games',
					    'type': 'boolean',
					    'difficulty': 'medium',
					    'question': 'In \'Team Fortress 2\', the \'Bill\'s Hat\' is a reference to the game \'Dota 2\'.',
					    'correct_answer': 'False',
					    'incorrect_answers': [
						    'True'
					    ]
				    },
				    {
					    'category': 'Entertainment: Video Games',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'Meryl Silverburgh, a video game character from the Metal Gear series, was originally a character in which game?',
					    'correct_answer': 'Policenauts',
					    'incorrect_answers': [
						    'Gradius',
						    'Contra',
						    'Castlevania: Symphony of the Night'
					    ]
				    },
				    {
					    'category': 'Entertainment: Television',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'Guy\'s Grocery Games is hosted by which presenter?',
					    'correct_answer': 'Guy Fieri',
					    'incorrect_answers': [
						    'Guy Martin',
						    'Guy Ritchie',
						    'Ainsley Harriott'
					    ]
				    },
				    {
					    'category': 'Entertainment: Music',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'What is the name of French electronic music producer Madeon\'s 2015 debut studio album?',
					    'correct_answer': 'Adventure',
					    'incorrect_answers': [
						    'The City',
						    'Icarus',
						    'Pop Culture'
					    ]
				    },
				    {
					    'category': 'Science & Nature',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'Which of the following plastic is commonly used for window frames, gutters and drain pipes?',
					    'correct_answer': 'Polyvinylchloride (PVC) ',
					    'incorrect_answers': [
						    'Polyethylene (PE)',
						    'Polypropylene (PP)',
						    'Polystyrene (PS)'
					    ]
				    },
				    {
					    'category': 'Art',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Which of these are the name of a famous marker brand?',
					    'correct_answer': 'Copic',
					    'incorrect_answers': [
						    'Dopix',
						    'Cofix',
						    'Marx'
					    ]
				    },
				    {
					    'category': 'Entertainment: Television',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'Who played the sun baby in the original run of Teletubbies?',
					    'correct_answer': 'Jessica Smith',
					    'incorrect_answers': [
						    'Pui Fan Lee',
						    'Sue Monroe',
						    'Lisa Brockwell'
					    ]
				    },
				    {
					    'category': 'Science & Nature',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'How many chromosomes are in your body cells?',
					    'correct_answer': '23',
					    'incorrect_answers': [
						    '21',
						    '22',
						    '24'
					    ]
				    },
				    {
					    'category': 'Politics',
					    'type': 'boolean',
					    'difficulty': 'hard',
					    'question': 'Joko Widodo has appeared in the cover of a TIME magazine.',
					    'correct_answer': 'True',
					    'incorrect_answers': [
						    'False'
					    ]
				    },
				    {
					    'category': 'Entertainment: Video Games',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'In the Portal series of games, who was the founder of Aperture Science?',
					    'correct_answer': 'Cave Johnson',
					    'incorrect_answers': [
						    'GLaDOs',
						    'Wallace Breen',
						    'Gordon Freeman'
					    ]
				    },
				    {
					    'category': 'Entertainment: Japanese Anime & Manga',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'Which of the following anime of the mecha genre began airing in 1982?',
					    'correct_answer': 'The Super Dimension Fortress Macross',
					    'incorrect_answers': [
						    'Mobile Suit Gundam',
						    'Armored Trooper VOTOMS',
						    'Neon Genesis Evangelion'
					    ]
				    },
				    {
					    'category': 'Geography',
					    'type': 'multiple',
					    'difficulty': 'medium',
					    'question': 'What is the largest Muslim country in the world?',
					    'correct_answer': 'Indonesia',
					    'incorrect_answers': [
						    'Pakistan',
						    'Saudi Arabia',
						    'Iran'
					    ]
				    },
				    {
					    'category': 'Science: Mathematics',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'What is the 100th digit of Pi?',
					    'correct_answer': '9',
					    'incorrect_answers': [
						    '4',
						    '7',
						    '2'
					    ]
				    },
				    {
					    'category': 'Science: Computers',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'The numbering system with a radix of 16 is more commonly referred to as ',
					    'correct_answer': 'Hexidecimal',
					    'incorrect_answers': [
						    'Binary',
						    'Duodecimal',
						    'Octal'
					    ]
				    },
				    {
					    'category': 'Entertainment: Music',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'Who wrote the song \'You Know You Like It\'?',
					    'correct_answer': 'AlunaGeorge',
					    'incorrect_answers': [
						    'DJ Snake',
						    'Steve Aoki',
						    'Major Lazer'
					    ]
				    },
				    {
					    'category': 'Entertainment: Japanese Anime & Manga',
					    'type': 'multiple',
					    'difficulty': 'easy',
					    'question': 'In the 2012 animated film \'Wolf Children\', what are the names of the wolf children?',
					    'correct_answer': 'Ame & Yuki',
					    'incorrect_answers': [
						    'Hana & Yuki',
						    'Ame & Hana',
						    'Chuck & Anna'
					    ]
				    },
				    {
					    'category': 'Entertainment: Television',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'Which of these in the Star Trek series is NOT Klingon food?',
					    'correct_answer': 'Hors d\'oeuvre',
					    'incorrect_answers': [
						    'Racht',
						    'Gagh',
						    'Bloodwine'
					    ]
				    },
				    {
					    'category': 'Entertainment: Film',
					    'type': 'multiple',
					    'difficulty': 'hard',
					    'question': 'Before \'Jurassic Park III\' was finalized and the Spinosaurus was chosen, which dinosaur was going to be the star?',
					    'correct_answer': 'Baryonyx',
					    'incorrect_answers': [
						    'Tyrannosaurus Rex',
						    'Velociraptor',
						    'Suchomimus'
					    ]
				    },
		{
						'category': 'Science & Nature',
						'type': 'boolean',
						'difficulty': 'medium',
						'question': 'The Neanderthals were a direct ancestor of modern humans.',
						'correct_answer': 'False',
						'incorrect_answers': [
							'True'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What was the character Kirby originally going to be named?',
						'correct_answer': 'Popopo',
						'incorrect_answers': [
							'Dedede',
							'Waddle Dee',
							'Prince Puff'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which French duo had UK hits in 1998 with the songs \'Sexy Boy\', \'Kelly Watch The Stars\' & \'All I Need\'?',
						'correct_answer': 'Air',
						'incorrect_answers': [
							'Fire',
							'Earth',
							'Water'
						]
					},
					{
						'category': 'Entertainment: Film',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What was Marilyn Monroe`s character\'s first name in the film \'Some Like It Hot\'?',
						'correct_answer': 'Sugar',
						'incorrect_answers': [
							'Honey',
							'Caramel',
							'Candy'
						]
					},
					{
						'category': 'Geography',
						'type': 'boolean',
						'difficulty': 'easy',
						'question': 'A group of islands is called an \'archipelago\'.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'Entertainment: Cartoon & Animations',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Butters Stotch, Pip Pirrup, and Wendy Testaburger are all characters in which long running animated TV series?',
						'correct_answer': 'South Park',
						'incorrect_answers': [
							'The Simpsons',
							'Family Guy',
							'Bob\'s Burgers'
						]
					},
					{
						'category': 'Science & Nature',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'What common name is given to the medial condition, tibial stress syndrome (MTSS)?',
						'correct_answer': 'Shin Splints',
						'incorrect_answers': [
							'Tennis Elbow',
							'Carpal Tunnel',
							'Housemaid\'s Knee'
						]
					},
					{
						'category': 'Entertainment: Cartoon & Animations',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Who is the only voice actor to have a speaking part in all of the Disney Pixar feature films? ',
						'correct_answer': 'John Ratzenberger',
						'incorrect_answers': [
							'Tom Hanks',
							'Dave Foley',
							'Geoffrey Rush'
						]
					},
					{
						'category': 'Vehicles',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which country has the international vehicle registration letter \'A\'?',
						'correct_answer': 'Austria',
						'incorrect_answers': [
							'Afghanistan',
							'Australia',
							'Armenia'
						]
					},
					{
						'category': 'Entertainment: Film',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Who directed the 1973 film \'American Graffiti\'?',
						'correct_answer': 'George Lucas',
						'incorrect_answers': [
							'Ron Howard',
							'Francis Ford Coppola',
							'Steven Spielberg'
						]
					},
					{
						'category': 'Entertainment: Board Games',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'At the start of a standard game of the Monopoly, if you throw a double six, which square would you land on?',
						'correct_answer': 'Electric Company',
						'incorrect_answers': [
							'Water Works',
							'Chance',
							'Community Chest'
						]
					},
					{
						'category': 'Entertainment: Books',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Who wrote the children\'s story \'The Little Match Girl\'?',
						'correct_answer': 'Hans Christian Andersen',
						'incorrect_answers': [
							'Charles Dickens',
							'Lewis Carroll',
							'Oscar Wilde'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which band released songs such as \'Electric Feel\', \'Kids\', and \'Time to Pretend\'?',
						'correct_answer': 'MGMT',
						'incorrect_answers': [
							'Passion Pit',
							'Phoenix',
							'Franz Ferdinand'
						]
					},
					{
						'category': 'Science: Mathematics',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'What\'s the square root of 49?',
						'correct_answer': '7',
						'incorrect_answers': [
							'4',
							'12',
							'9'
						]
					},
					{
						'category': 'History',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Which of the following African countries was most successful in resisting colonization?',
						'correct_answer': 'Ethiopia',
						'incorrect_answers': [
							'Côte d\'Ivoire',
							'Congo',
							'Namibia'
						]
					},
					{
						'category': 'History',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'The Herero genocide was perpetrated in Africa by which of the following colonial nations?',
						'correct_answer': 'Germany',
						'incorrect_answers': [
							'Britain',
							'Belgium',
							'France'
						]
					},
					{
						'category': 'Science: Computers',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'The computer OEM manufacturer Clevo, known for its Sager notebook line, is based in which country?',
						'correct_answer': 'Taiwan',
						'incorrect_answers': [
							'United States',
							'Germany',
							'China (People\'s Republic of)'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'How many time zones does China have?',
						'correct_answer': '1',
						'incorrect_answers': [
							'3',
							'4',
							'2'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'How many countries does the United States share a land border with?',
						'correct_answer': '2',
						'incorrect_answers': [
							'1',
							'3',
							'4'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'What is the official language of Costa Rica?',
						'correct_answer': 'Spanish',
						'incorrect_answers': [
							'English',
							'Portuguese',
							'Creole'
						]
					},
					{
						'category': 'General Knowledge',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Red Vines is a brand of what type of candy?',
						'correct_answer': 'Licorice',
						'incorrect_answers': [
							'Lollipop',
							'Chocolate',
							'Bubblegum'
						]
					},
					{
						'category': 'Animals',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'How many legs do butterflies have?',
						'correct_answer': '6',
						'incorrect_answers': [
							'2',
							'4',
							'0'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Which of these is the name of the largest city in the US state Tennessee?',
						'correct_answer': 'Memphis',
						'incorrect_answers': [
							'Thebes',
							'Alexandria',
							'Luxor'
						]
					},
					{
						'category': 'History',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'In what prison was Adolf Hitler held in 1924?',
						'correct_answer': 'Landsberg Prison',
						'incorrect_answers': [
							'Spandau Prison',
							'Ebrach Abbey',
							'Hohenasperg'
						]
					},
					{
						'category': 'Geography',
						'type': 'boolean',
						'difficulty': 'easy',
						'question': 'Ottawa is the capital of Canada.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'boolean',
						'difficulty': 'hard',
						'question': 'In \'Metal Gear Solid 2\', you will see through the eyes of Psycho Mantis if you go first person during his boss fight.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What is the capital of Senegal?',
						'correct_answer': 'Dakar',
						'incorrect_answers': [
							'Nouakchott',
							'Conakry',
							'Monrovia'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'In Overwatch, Mercy\'s ultimate ability is..',
						'correct_answer': 'Resurrect',
						'incorrect_answers': [
							'Earthshatter',
							'Rocket Barrage',
							'Molten Core'
						]
					},
					{
						'category': 'Entertainment: Musicals & Theatres',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'In Jeff Wayne\'s Musical Version of War of the Worlds, the chances of anything coming from Mars are...',
						'correct_answer': 'A million to one',
						'incorrect_answers': [
							'A billion to one',
							'A trillion to one',
							'A hundred to one'
						]
					},
					{
						'category': 'Sports',
						'type': 'boolean',
						'difficulty': 'medium',
						'question': 'The Olympics tennis court is a giant green screen.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'Geography',
						'type': 'boolean',
						'difficulty': 'medium',
						'question': 'You could walk from Norway to North Korea while only passing through Russia.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'Science & Nature',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'What is the molecular formula of Ozone?',
						'correct_answer': 'O₃',
						'incorrect_answers': [
							'C₂H₂O₆',
							'N₂O',
							'SO₄'
						]
					},
					{
						'category': 'Entertainment: Books',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'J.K. Rowling completed \'Harry Potter and the Deathly Hallows\' in which hotel in Edinburgh, Scotland?',
						'correct_answer': 'The Balmoral',
						'incorrect_answers': [
							'The Dunstane Hotel',
							'Hotel Novotel',
							'Sheraton Grand Hotel & Spa'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'During the game\'s development, what was the first ever created Pokémon?',
						'correct_answer': 'Rhyhorn',
						'incorrect_answers': [
							'Bulbasaur',
							'Mew',
							'Arceus'
						]
					},
					{
						'category': 'Science: Computers',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What is the correct term for the metal object in between the CPU and the CPU fan within a computer system?',
						'correct_answer': 'Heat Sink',
						'incorrect_answers': [
							'CPU Vent',
							'Temperature Decipator',
							'Heat Vent'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Who is the frontman of Muse?',
						'correct_answer': 'Matt Bellamy',
						'incorrect_answers': [
							'Dominic Howard',
							'Thom Yorke',
							'Jonny Greenwood'
						]
					},
					{
						'category': 'Science: Gadgets',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Who patented a steam engine that produced continuous rotary motion?',
						'correct_answer': 'James Watt',
						'incorrect_answers': [
							'Nikola Tesla',
							'Albert Einstein',
							'Alessandro Volta'
						]
					},
					{
						'category': 'General Knowledge',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'Which one of these Swedish companies was founded in 1943?',
						'correct_answer': 'IKEA',
						'incorrect_answers': [
							'H & M',
							'Lindex',
							'Clas Ohlson'
						]
					},
					{
						'category': 'Sports',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What national team won the 2016 edition of UEFA European Championship?',
						'correct_answer': 'Portugal',
						'incorrect_answers': [
							'France',
							'Germany',
							'England'
						]
					},
					{
						'category': 'Entertainment: Books',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'The book \'The Little Prince\' was written by...',
						'correct_answer': 'Antoine de Saint-Exupéry',
						'incorrect_answers': [
							'Miguel de Cervantes Saavedra',
							'Jane Austen',
							'F. Scott Fitzgerald'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What is the capital of Slovakia?',
						'correct_answer': 'Bratislava',
						'incorrect_answers': [
							'Sofia',
							'Ljubljana',
							'Sarajevo'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': '\'All the Boys\' by Panic! At the Disco was released as a bonus track on what album?',
						'correct_answer': 'Too Weird To Live, Too Rare To Die!',
						'incorrect_answers': [
							'A Fever You Can\'t Sweat Out',
							'Death Of A Bachelor',
							'Vices & Virtues'
						]
					},
					{
						'category': 'History',
						'type': 'boolean',
						'difficulty': 'medium',
						'question': 'The Hundred Years\' War was fought for more than a hundred years.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'History',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'When did the United States formally declare war on Japan, entering World War II?',
						'correct_answer': 'December 8, 1941',
						'incorrect_answers': [
							'June 6, 1944',
							'June 22, 1941',
							'September 1, 1939'
						]
					},
					{
						'category': 'Entertainment: Film',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': '\'The first rule is: you don\'t talk about it\' is a reference to which movie?',
						'correct_answer': 'Fight Club',
						'incorrect_answers': [
							'The Island',
							'Unthinkable',
							'American Pie'
						]
					},
					{
						'category': 'Science & Nature',
						'type': 'boolean',
						'difficulty': 'hard',
						'question': 'The chemical element Lithium is named after the country of Lithuania.',
						'correct_answer': 'False',
						'incorrect_answers': [
							'True'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'boolean',
						'difficulty': 'easy',
						'question': 'Scatman John\'s real name was John Paul Larkin.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'General Knowledge',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'How tall is the Burj Khalifa?',
						'correct_answer': '2,722 ft',
						'incorrect_answers': [
							'2,717 ft',
							'2,546 ft',
							'3,024 ft'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Who is the English voice actor for Sora from the Kingdom Hearts series?',
						'correct_answer': 'Haley Joel Osment',
						'incorrect_answers': [
							'Kōki Uchiyama',
							'Jesse McCartney',
							'Miyu Irino'
						]
					},
					{
						'category': 'Celebrities',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Who out of these actresses is the youngest?',
						'correct_answer': 'Kiernan Shipka',
						'incorrect_answers': [
							'Ariel Winter',
							'Emma Watson',
							'Bonnie Wright'
						]
					},
		{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Killing Floor started as a mod for which Unreal Engine 2 game?',
						'correct_answer': 'Unreal Tournament 2004',
						'incorrect_answers': [
							'Deus Ex: Invisible War',
							'Unreal Tournament 3',
							'Postal'
						]
					},
					{
						'category': 'General Knowledge',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What does a milliner make and sell?',
						'correct_answer': 'Hats',
						'incorrect_answers': [
							'Shoes',
							'Belts',
							'Shirts'
						]
					},
					{
						'category': 'Vehicles',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which animal features on the logo for Abarth, the motorsport division of Fiat?',
						'correct_answer': 'Scorpion',
						'incorrect_answers': [
							'Snake',
							'Bull',
							'Horse'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'On a London Underground map, what colour is the Circle Line?',
						'correct_answer': 'Yellow',
						'incorrect_answers': [
							'Red',
							'Blue',
							'Green'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Which English guitarist has the nickname \'Slowhand\'?',
						'correct_answer': 'Eric Clapton',
						'incorrect_answers': [
							'Mark Knopfler',
							'Jeff Beck',
							'Jimmy Page'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'boolean',
						'difficulty': 'medium',
						'question': 'Arcade Fire\'s \'The Suburbs\' won the Album of the Year award in the 2011 Grammys.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'History',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Which one of these tanks was designed and operated by the United Kingdom?',
						'correct_answer': 'Tog II',
						'incorrect_answers': [
							'M4 Sherman',
							'Tiger H1',
							'T-34'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Whose signature guitar technique is called the \'windmill\'?',
						'correct_answer': 'Pete Townshend',
						'incorrect_answers': [
							'Jimmy Page',
							'Eddie Van Halen',
							'Jimi Hendrix'
						]
					},
					{
						'category': 'Entertainment: Film',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Who directed the 2015 movie \'The Revenant\'?',
						'correct_answer': 'Alejandro G. Iñárritu',
						'incorrect_answers': [
							'Christopher Nolan',
							'David Fincher',
							'Wes Anderson'
						]
					},
					{
						'category': 'Entertainment: Film',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'What did Alfred Hitchcock use as blood in the film \'Psycho\'? ',
						'correct_answer': 'Chocolate syrup',
						'incorrect_answers': [
							'Ketchup',
							'Red food coloring',
							'Maple syrup'
						]
					},
					{
						'category': 'Science: Mathematics',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'What\'s the square root of 49?',
						'correct_answer': '7',
						'incorrect_answers': [
							'4',
							'12',
							'9'
						]
					},
					{
						'category': 'Science: Mathematics',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What is the first Mersenne prime over 1000?',
						'correct_answer': '1279',
						'incorrect_answers': [
							'2203',
							'1009',
							'1069'
						]
					},
					{
						'category': 'Entertainment: Musicals & Theatres',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which of these musicals won the Tony Award for Best Musical?',
						'correct_answer': 'Rent',
						'incorrect_answers': [
							'The Color Purple',
							'American Idiot',
							'Newsies'
						]
					},
					{
						'category': 'Politics',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'The largest consumer market in 2015 was...',
						'correct_answer': 'The United States of America',
						'incorrect_answers': [
							'Germany',
							'Japan',
							'United Kingdom'
						]
					},
					{
						'category': 'Art',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'What year did Albrecht DÜrer create the painting \'The Young Hare\'?',
						'correct_answer': '1502',
						'incorrect_answers': [
							'1702',
							'1402',
							'1602'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which of these countries is located the FURTHEST away from the South China Sea?',
						'correct_answer': 'Bangladesh',
						'incorrect_answers': [
							'Malaysia',
							'Vietnam',
							'Philippines'
						]
					},
					{
						'category': 'Entertainment: Japanese Anime & Manga',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'When was the first episode of Soul Eater released?',
						'correct_answer': '2008',
						'incorrect_answers': [
							'2003',
							'2005',
							'2011'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which Toronto landmark was featured on the cover art of Canadian rapper Drake\'s 2016 album \'Views\'?',
						'correct_answer': 'CN Tower',
						'incorrect_answers': [
							'Allan Gardens',
							'Union Station',
							'Prince of Wales Theatre'
						]
					},
					{
						'category': 'Science: Computers',
						'type': 'boolean',
						'difficulty': 'easy',
						'question': 'RAM stands for Random Access Memory.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Gibraltar, located just south of the Iberian peninsula, is a territory of which West Europe country?',
						'correct_answer': 'United Kingdom',
						'incorrect_answers': [
							'Spain',
							'Portugal',
							'France'
						]
					},
					{
						'category': 'Entertainment: Film',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Which of these movies did Jeff Bridges not star in?',
						'correct_answer': 'The Hateful Eight',
						'incorrect_answers': [
							'Tron: Legacy',
							'The Giver',
							'True Grit'
						]
					},
					{
						'category': 'Science & Nature',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What is the atomic number of the element Strontium?',
						'correct_answer': '38',
						'incorrect_answers': [
							'73',
							'47',
							'11'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'What is the stage name of English female rapper Mathangi Arulpragasam, who is known for the song \'Paper Planes\'?',
						'correct_answer': 'M.I.A.',
						'incorrect_answers': [
							'K.I.A.',
							'C.I.A.',
							'A.I.A.'
						]
					},
					{
						'category': 'Entertainment: Cartoon & Animations',
						'type': 'boolean',
						'difficulty': 'easy',
						'question': 'Bill Cipher in the show \'Gravity Falls\' is the good guy.',
						'correct_answer': 'False',
						'incorrect_answers': [
							'True'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which game was the first time Mario was voiced by Charles Martinet?',
						'correct_answer': 'Mario\'s Game Gallery',
						'incorrect_answers': [
							'Super Mario 64',
							'Mario Tennis',
							'Dr. Mario 64'
						]
					},
					{
						'category': 'History',
						'type': 'boolean',
						'difficulty': 'medium',
						'question': 'Theodore Roosevelt Jr. was the only General involved in the initial assault on D-Day.',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'Mythology',
						'type': 'boolean',
						'difficulty': 'medium',
						'question': 'The Japanese god Izanagi successfully returned his wife Izanami from the Underworld.',
						'correct_answer': 'False',
						'incorrect_answers': [
							'True'
						]
					},
					{
						'category': 'Entertainment: Japanese Anime & Manga',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'The main antagonist of the second part of JoJo\'s Bizarre Adventure is which of the following?',
						'correct_answer': 'Kars',
						'incorrect_answers': [
							'Erina Joestar',
							'Santana',
							'Wired Beck'
						]
					},
					{
						'category': 'History',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'How many sonatas did Ludwig van Beethoven write?',
						'correct_answer': '32',
						'incorrect_answers': [
							'50',
							'31',
							'21'
						]
					},
					{
						'category': 'Entertainment: Cartoon & Animations',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'In the web-comic Homestuck, what is the name of the game the 4 kids play?',
						'correct_answer': 'Sburb',
						'incorrect_answers': [
							'Homesick',
							'Husslie',
							'Hiveswap'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'boolean',
						'difficulty': 'medium',
						'question': 'TF2: The Heavy\'s voice actor, Gary Schwartz, voices the Demoman as well ',
						'correct_answer': 'True',
						'incorrect_answers': [
							'False'
						]
					},
					{
						'category': 'Entertainment: Musicals & Theatres',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'In Jeff Wayne\'s Musical Version of War of the Worlds, the chances of anything coming from Mars are...',
						'correct_answer': 'A million to one',
						'incorrect_answers': [
							'A billion to one',
							'A trillion to one',
							'A hundred to one'
						]
					},
					{
						'category': 'Art',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which one of these paintings is not by Caspar David Friedrich?',
						'correct_answer': 'The Black Sea',
						'incorrect_answers': [
							'The Sea of Ice',
							'Wanderer above the Sea of Fog',
							'The Monk by the Sea'
						]
					},
					{
						'category': 'History',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What is the oldest US state?',
						'correct_answer': 'Delaware',
						'incorrect_answers': [
							'Rhode Island',
							'Maine',
							'Virginia'
						]
					},
					{
						'category': 'Science: Computers',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'What is the correct term for the metal object in between the CPU and the CPU fan within a computer system?',
						'correct_answer': 'Heat Sink',
						'incorrect_answers': [
							'CPU Vent',
							'Temperature Decipator',
							'Heat Vent'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'What was the world\'s first handheld game device?',
						'correct_answer': 'Mattel Auto Race',
						'incorrect_answers': [
							'Game Boy',
							'Microvision',
							'Game & Watch'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'What is the name of the peninsula containing Spain and Portugal?',
						'correct_answer': 'Iberian Peninsula',
						'incorrect_answers': [
							'European Peninsula',
							'Peloponnesian Peninsula',
							'Scandinavian Peninsula'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'boolean',
						'difficulty': 'easy',
						'question': 'In the game \'Subnautica\', a \'Spadefish\' will attack you.',
						'correct_answer': 'False',
						'incorrect_answers': [
							'True'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'In Halo 2, how many rounds does the M6C hold in a single magazine?',
						'correct_answer': '12',
						'incorrect_answers': [
							'6',
							'36',
							'18'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which of these is not the name of a city in the Grand Theft Auto series?',
						'correct_answer': 'San Andreas',
						'incorrect_answers': [
							'San Fierro',
							'Las Venturas',
							'Vice City'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'boolean',
						'difficulty': 'easy',
						'question': 'The names of Tom Nook\'s cousins in the Animal Crossing franchise are named \'Timmy\' and \'Jimmy\'.',
						'correct_answer': 'False',
						'incorrect_answers': [
							'True'
						]
					},
					{
						'category': 'General Knowledge',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'According to Sherlock Holmes, \'If you eliminate the impossible, whatever remains, however improbable, must be the...\'',
						'correct_answer': 'Truth',
						'incorrect_answers': [
							'Answer',
							'Cause',
							'Source'
						]
					},
					{
						'category': 'Geography',
						'type': 'multiple',
						'difficulty': 'hard',
						'question': 'What is the official German name of the Swiss Federal Railways?',
						'correct_answer': 'Schweizerische Bundesbahnen',
						'incorrect_answers': [
							'Schweizerische Nationalbahnen',
							'Bundesbahnen der Schweiz',
							'Schweizerische Staatsbahnen'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'In what year was the game \'FTL: Faster Than Light\' released?',
						'correct_answer': '2012',
						'incorrect_answers': [
							'2014',
							'2013',
							'2011'
						]
					},
					{
						'category': 'Science: Computers',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'The numbering system with a radix of 16 is more commonly referred to as ',
						'correct_answer': 'Hexidecimal',
						'incorrect_answers': [
							'Binary',
							'Duodecimal',
							'Octal'
						]
					},
					{
						'category': 'Entertainment: Music',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Which song on Daft Punk\'s \'Random Access Memories\' features Pharrell Williams?',
						'correct_answer': 'Get Lucky',
						'incorrect_answers': [
							'Doin\' It Right',
							'Instant Crush',
							'The Game of Love'
						]
					},
					{
						'category': 'Celebrities',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'Which famous New York Yankees outfielder did Marilyn Monroe marry?',
						'correct_answer': 'Joe DiMaggio',
						'incorrect_answers': [
							'Tino Martinez',
							'Babe Ruth',
							'Mason Williams'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'boolean',
						'difficulty': 'easy',
						'question': 'In RuneScape, one must complete the \'Dragon Slayer\' quest before equipping Rune Platelegs.',
						'correct_answer': 'False',
						'incorrect_answers': [
							'True'
						]
					},
					{
						'category': 'Entertainment: Video Games',
						'type': 'multiple',
						'difficulty': 'medium',
						'question': 'In what year was \'Super Mario Sunshine\' released?',
						'correct_answer': '2002',
						'incorrect_answers': [
							'2003',
							'2000',
							'2004'
						]
					},
					{
						'category': 'Sports',
						'type': 'multiple',
						'difficulty': 'easy',
						'question': 'Which team has won the most Stanley Cups in the NHL?',
						'correct_answer': 'Montreal Canadians',
						'incorrect_answers': [
							'Chicago Blackhawks',
							'Toronto Maple Leafs',
							'Detroit Red Wings'
						]
					}
                ]}");
    }
}