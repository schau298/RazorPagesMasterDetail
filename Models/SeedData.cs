using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMasterDetail.Data;

namespace RazorPagesMasterDetail.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMasterDetailContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMasterDetailContext>>()))
            {
                //look for books
                if (context.Books.Any())
                {
                    return;   // DB has been seeded
                }

                context.Books.AddRange(
                    new Books
                    {
                        Date = DateTime.Parse("06-01-1998"),
                        Title = "Pride and Prejudice",
                        Author = "Austen, Jane",
                        Genre = "Courtship -- Fiction,Domestic fiction,England -- Fiction,Love stories,Sisters -- Fiction,Social classes -- Fiction,Young women -- Fiction",
                        Cover = "https://www.gutenberg.org/cache/epub/1342/pg1342.cover.medium.jpg",
                        Summary = "“I am by no means of the opinion, I assure you,” said he, “that a ball of this kind, given by a young man of character, to respectable people, can have any evil tendency; and I am so far from objecting to dancing myself, that I shall hope to be honoured with the hands of all my fair cousins in the course of the evening; and I take this opportunity of soliciting yours, Miss Elizabeth, for the two first dances especially, a preference which I trust my cousin Jane will attribute to the right cause, and not to any disrespect for her.”Bennet this morning that if you ever resolved on quitting Netherfield you should be gone in five minutes, you meant it to be a sort of panegyric, of compliment to yourself—and yet what is there so very laudable in a precipitance which must leave very necessary business undone, and can be of no real advantage to yourself or any one else?Though her brother and sister were persuaded that there was no real occasion for such a seclusion from the family, they did not attempt to oppose it, for they knew that she had not prudence enough to hold her tongue before the servants, while they waited at table, and judged it better that _one_ only of the household, and the one whom they could most trust should comprehend all her fears and solicitude on the subject.Jane recollected herself soon, and putting the letter away, tried to join with her usual cheerfulness in the general conversation; but Elizabeth felt an anxiety on the subject which drew off her attention even from Wickham; and no sooner had he and his companion taken leave, than a glance from Jane invited her to follow her up stairs."
                    },

                    new Books
                    {
                        Date = DateTime.Parse("06-27-2008"),
                        Title = "Alice's Adventures in Wonderland",
                        Author = "Carroll, Lewis",
                        Genre = "Alice (Fictitious character from Carroll) -- Juvenile fiction,Children's stories,Fantasy fiction,Imaginary places -- Juvenile fiction",
                        Cover = "https://www.gutenberg.org/cache/epub/11/pg11.cover.medium.jpg",
                        Summary = "Hardly knowing what she did, she picked up a little bit of stick, and held it out to the puppy; whereupon the puppy jumped into the air off all its feet at once, with a yelp of delight, and rushed at the stick, and made believe to worry it; then Alice dodged behind a great thistle, to keep herself from being run over; and the moment she appeared on the other side, the puppy made another rush at the stick, and tumbled head over heels in its hurry to get hold of it; then Alice, thinking it was very like having a game of play with a cart-horse, and expecting every moment to be trampled under its feet, ran round the thistle again; then the puppy began a series of short charges at the stick, running a very little way forwards each time and a long way back, and barking hoarsely all the while, till at last it sat down a good way off, panting, with its tongue hanging out of its mouth, and its great eyes half shut.There seemed to be no use in waiting by the little door, so she went back to the table, half hoping she might find another key on it, or at any rate a book of rules for shutting people up like telescopes: this time she found a little bottle on it, (“which certainly was not here before,” said Alice,) and round the neck of the bottle was a paper label, with the words “DRINK ME,” beautifully printed on it in large letters.At last the Mock Turtle recovered his voice, and, with tears running down his cheeks, he went on again:— “You may not have lived much under the sea—” (“I haven’t,” said Alice)—“and perhaps you were never even introduced to a lobster—” (Alice began to say “I once tasted—” but checked herself hastily, and said “No, never”) “—so you can have no idea what a delightful thing a Lobster Quadrille is!There was no “One, two, three, and away,” but they began running when they liked, and left off when they liked, so that it was not easy to know when the race was over."
                    },

                    new Books
                    {
                        Date = DateTime.Parse("03-01-1999"),
                        Title = "The Adventures of Sherlock Holmes",
                        Author = "Doyle, Arthur Conan",
                        Genre = "Detective and mystery stories, English,Holmes, Sherlock (Fictitious character) -- Fiction,Private investigators -- England -- Fiction",
                        Cover = "https://www.gutenberg.org/cache/epub/1661/pg1661.cover.medium.jpg",
                        Summary = "No, sir, I shall approach this case from the point of view that what this young man says is true, and we shall see whither that hypothesis will lead us.The man in the road was undoubtedly some friend of hers—possibly her _fiancé_—and no doubt, as you wore the girl’s dress and were so like her, he was convinced from your laughter, whenever he saw you, and afterwards from your gesture, that Miss Rucastle was perfectly happy, and that she no longer desired his attentions.“It was from the reigning family of Holland, though the matter in which I served them was of such delicacy that I cannot confide it even to you, who have been good enough to chronicle one or two of my little problems.”” “No; but one of them was mine all the same,” whined the little man."
                    },

                    new Books
                    {
                        Date = DateTime.Parse("10-01-1993"),
                        Title = "Frankenstein; Or, The Modern Prometheus",
                        Author = "Shelley, Mary Wollstonecraft",
                        Genre = "Frankenstein's monster (Fictitious character) -- Fiction,Frankenstein, Victor (Fictitious character) -- Fiction,Gothic fiction,Horror tales,Monsters -- Fiction,Science fiction,Scientists -- Fiction",
                        Cover = "https://www.gutenberg.org/cache/epub/84/pg84.cover.medium.jpg",
                        Summary = "I said in one of my letters, my dear Margaret, that I should find no friend on the wide ocean; yet I have found a man who, before his spirit had been broken by misery, I should have been happy to have possessed as the brother of my heart.A woman deposed that she lived near the beach and was standing at the door of her cottage, waiting for the return of the fishermen, about an hour before she heard of the discovery of the body, when she saw a boat with only one man in it push off from that part of the shore where the corpse was afterwards found.But death was no evil to me if the loss of Elizabeth were balanced with it, and I therefore, with a contented and even cheerful countenance, agreed with my father that if my cousin would consent, the ceremony should take place in ten days, and thus put, as I imagined, the seal to my fate.A great fall of snow had taken place the night before, and the fields were of one uniform white; the appearance was disconsolate, and I found my feet chilled by the cold damp substance that covered the ground."
                    },

                    new Books
                    {
                        Date = DateTime.Parse("07-01-2001"),
                        Title = "Moby Dick; Or, The Whale",
                        Author = "Melville, Herman",
                        Genre = "Adventure stories,Ahab, Captain (Fictitious character) -- Fiction,Mentally ill -- Fiction,Psychological fiction,Sea stories,Ship captains -- Fiction,Whales -- Fiction,Whaling -- Fiction,Whaling ships -- Fiction",
                        Cover = "https://www.gutenberg.org/cache/epub/2701/pg2701.cover.small.jpg",
                        Summary = "While the two crews were yet circling in the waters, reaching out after the revolving line-tubs, oars, and other floating furniture, while aslope little Flask bobbed up and down like an empty vial, twitching his legs upwards to escape the dreaded jaws of sharks; and Stubb was lustily singing out for some one to ladle him up; and while the old man’s line—now parting—admitted of his pulling into the creamy pool to rescue whom he could;—in that wild simultaneousness of a thousand concreted perils,—Ahab’s yet unstricken boat seemed drawn up towards Heaven by invisible wires,—as, arrow-like, shooting perpendicularly from the sea, the White Whale dashed his broad forehead against its bottom, and sent it, turning over and over, into the air; till it fell again—gunwale downwards—and Ahab and his men struggled out from under it, like seals from a sea-side cave.But though, to landsmen in general, the native inhabitants of the seas have ever been regarded with emotions unspeakably unsocial and repelling; though we know the sea to be an everlasting terra incognita, so that Columbus sailed over numberless unknown worlds to discover his one superficial western one; though, by vast odds, the most terrific of all mortal disasters have immemorially and indiscriminately befallen tens and hundreds of thousands of those who have gone upon the waters; though but a moment’s consideration will teach, that however baby man may brag of his science and skill, and however much, in a flattering future, that science and skill may augment; yet for ever and for ever, to the crack of doom, the sea will insult and murder him, and pulverize the stateliest, stiffest frigate he can make; nevertheless, by the continual repetition of these very impressions, man has lost that sense of the full awfulness of the sea which aboriginally belongs to it.Because, in the first place, he somehow seemed dull of hearing on that important subject, unless considered from his own point of view; and, in the second place, he did not more than one third understand me, couch my ideas simply as I would; and, finally, he no doubt thought he knew a good deal more about the true religion than I did.No use sterning all, then; but as I was groping at midday, with a blinding sun, all crown-jewels; as I was groping, I say, after the second iron, to toss it overboard—down comes the tail like a Lima tower, cutting my boat in two, leaving each half in splinters; and, flukes first, the white hump backed through the wreck, as though it was all chips."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}