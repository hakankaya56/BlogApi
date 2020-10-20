Create Database 

ARTICLE_DB

GO

Create Table Articles (
 Id int not null identity(1,1) primary key,
 Title varchar(50),
 Content varchar(max),
 CreatedDate datetime,
 UpdatedDate datetime,
 CategoryID int
);




Create Table Categories (
Id int not null identity(1,1) primary key,
Name varchar(50), 
CreatedDate datetime,
UpdatedDate datetime
);

/* Kategori ekleme*/
INSERT INTO Categories (Name, CreatedDate, UpdatedDate) VALUES ('Film', GETDATE(), GETDATE());
INSERT INTO Categories (Name, CreatedDate, UpdatedDate) VALUES ('Book', GETDATE(), GETDATE());
INSERT INTO Categories (Name, CreatedDate, UpdatedDate) VALUES ('Music', GETDATE(), GETDATE());
INSERT INTO Categories (Name, CreatedDate, UpdatedDate) VALUES ('Poetry', GETDATE(), GETDATE());
INSERT INTO Categories (Name, CreatedDate, UpdatedDate) VALUES ('Photography', GETDATE(), GETDATE());
INSERT INTO Categories (Name, CreatedDate, UpdatedDate) VALUES ('Food', GETDATE(), GETDATE());

/* Makale Ekleme*/
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID)
VALUES ('The Unexpected Cast of Great Expectations', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.',
GETDATE(), GETDATE(), 1);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID)
VALUES ('Horror Isn’t All About the Scares','Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', GETDATE(), GETDATE(), 1);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID)
VALUES ('The Exorcist Serial Killer','Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.', GETDATE(), GETDATE(), 1);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('New Book Releases: October 20, 2020','Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem.', GETDATE(), GETDATE(), 2);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID)
VALUES ('Not As Easy As ABC','Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?', GETDATE(), GETDATE(), 2);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('The Cocktail Man','But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness', GETDATE(), GETDATE(), 2);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('The Ethics of the AI Song Contest','No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.', GETDATE(), GETDATE(), 3);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('Sturgill Simpson & How I Like My Music','Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure.', GETDATE(), GETDATE(), 3);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('Mariah Carey Reclaims Her Legacy','To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?', GETDATE(), GETDATE(), 3);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('Paint Their Wings','At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fugay', GETDATE(), GETDATE(), 4);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('Impervious','Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus.', GETDATE(), GETDATE(), 4);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('My Centre','Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.', GETDATE(), GETDATE(), 4);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('Capturing the Great Depression Era','On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue', GETDATE(), GETDATE(), 5);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('The Case Against Full Frame','qual blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain', GETDATE(), GETDATE(), 5);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('The Idea of Photography','hese cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.', GETDATE(), GETDATE(), 5);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('I Have Never Liked My Body','But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted', GETDATE(), GETDATE(), 6);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('We are what we eat','The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains.', GETDATE(), GETDATE(), 6);
INSERT INTO Articles(Title,Content, CreatedDate, UpdatedDate, CategoryID) 
VALUES ('8 Easy Ways to Eat More Vegetables','It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.', GETDATE(), GETDATE(), 6);



