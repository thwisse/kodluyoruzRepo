# kodluyoruzilkrepo
Kodluyoruz GIT Eğitimi kapsamında açtığım ilk repo.

## Aldığım bazı notlar:

### GIT Bash içinde GIT Komutları:

- git init (bir git dosyası oluştur ve git'i başlat)
- git status (git'in durumunu görüntüle)
- git add fileName (her değişiklik sonrası dosyayı git'e ekle) (staged. yani commitlenmeye hazır)
- git add . (takip edilen tüm dosyaları tek seferde staged hale getirir.)
- git commit (bir dosyayi ilk defa commit ederken kullanabilirsin)
- git commit -m 'info' (daha sonrakilerde message giriyoruz. zorunlu.)
- git diff (değişiklikleri görüntüle)
- git log (log kayıtlarına bak)
- git rm --cached fileName (dosyayı git'lemeyi bırak. bundan sonra da commit yapılmalı.)
- git branch -M main (main branch'ine geçiş)
- git remote add origin link (git'i repoya ilk defa bağlarken kullan.)
	- git remote (Bu komut, yerel git deposunu uzak sunucuya bağlamak için kullanılır.)
- git pull (repodan verileri çekme)
- git push (repoya verileri yollama)
- git clone link (uzak sunucudan bir repoyu clone'layabilirsin)
- code . (reponun klasöründeyken bunu git bash'te yazarak klasörü code'da açabiliriz.)
- git branch (branch'leri listeler)
- git branch -v (branch'leri detaylı listele)
- git branch branchName (yeni branch oluşturur)
- git checkout branchName (branchlar arası geçiş yapmayı sağlar)
- git push -u origin newBranchName (yeni branch'i remote'lamak)
- git branch -vva (tracking relationships yani kurulmuş takip ilişkisi bilgilerini de görebiliriz)
- git merge branchName (içinde bulunduğun branch ile branchName birleşir. içinde bulunduğun branch'e yazılır.)
- git stash (son değişiklikleri checkpoint almak)
- git stash list (alınan stashleri listele)
- git stash pop (en son alınan stash'i uygula ve listeden çıkar)
- git stash apply stashName (bu stashi uygula)
- git stash drop stashName (bu stash'i listeden kaldır)