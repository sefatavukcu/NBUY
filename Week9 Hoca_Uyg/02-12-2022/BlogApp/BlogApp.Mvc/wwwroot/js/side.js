// tarihi ilk başta oluştururken kısa yazdırma fonksiyonu
function convertToShortDate(dateString){
    const shortDate = new Date(dateString).toLocaleDateString('tr-TR');
    return shortDate;
}
// true false yazdırırken default olarak gelenlerin ilk harflerini büyük harfle yazdırma fonksiyonu
function convertFirstLetterToUpperCase(text){
    text = text.toString();
    const convertedText = text.charAt(0).toUpperCase() + text.slice(1).toLowerCase();
    return convertedText;
}