
$ImageMagikDir = "O:\Applications\ImageMagick-7.1.1-12-portable-Q8-x64\"

$Convert = "$ImageMagikDir\convert.exe"

$files = Get-Item *.png

New-Item -ItemType Directory "output" -ErrorAction SilentlyContinue

foreach ($file in $files) {

    $iconName = $file.Name.Replace(".png", ".ico").Replace("@2x", "").Replace("d_", "");

    . $Convert -background transparent $file.FullName -define icon:auto-resize=16,24,32,48,64,72,96,128,256 "output\$iconName"
}