aws s3 sync "\\morrisnas\multimedia\morrisphotos" s3://morrisphotos.com/Images --acl="public-read"
"C:\Program Files\WinHTTrack\httrack.exe" "http://localhost:12345" -O "C:\My Web Sites\MorrisPhotos" --update
aws s3 sync "C:\My Web Sites\MorrisPhotos\localhost_12345" s3://static-morrisphotos.com --acl="public-read"