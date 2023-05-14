# cs50-Dreadhalls

It is built using unity.
The version of unity is "2018.4.28f1"

Three function were added to base the cs50 code.

english
- [x]  Spawn holes in the floor of the maze that the player can fall through (but not too many; just three or four per maze is probably sufficient, depending on maze size).
- [x]  When the player falls through any holes, transition to a “Game Over” screen similar to the Title Screen, implemented as a separate scene. When the player presses “Enter” in the “Game Over” scene, they should be brought back to the title.
- [x]  Add a Text label to the Play scene that keeps track of which maze they’re in, incrementing each time they progress to the next maze. This can be implemented as a static variable, but it should be reset to 0 if they get a Game Over.
Fix the bug whereby the scroll speed of planes, coins, and buildings doesn’t reset when the game is restarted via the space bar.


japanese
- 迷路の床にプレイヤーが通れる穴を開ける（ただし、迷路の大きさにもよりますが、1つの迷路に3～4個程度で十分です）。
- プレイヤーが穴に落ちたら、タイトル画面のような「ゲームオーバー」画面に遷移し、別シーンとして実装します。Game Over」シーンでプレイヤーが「Enter」を押すと、タイトルに戻るようにする。
- プレイシーンにテキストラベルを追加し、プレイヤーがどの迷路にいるのかを記録し、次の迷路に進むたびにインクリメントする。これは静的変数として実装できますが、ゲームオーバーになった場合は0にリセットする必要があります。
