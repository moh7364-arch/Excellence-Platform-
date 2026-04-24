function toggleMenu(){
  const menu = document.getElementById('mainMenu');
  if(menu){ menu.classList.toggle('open'); }
}
function showRequestMessage(event){
  event.preventDefault();
  const msg = document.getElementById('requestMessage');
  if(msg){ msg.textContent = 'تم استلام الطلب تجريبياً. اربط النموذج بقاعدة بيانات عند تحويله للإنتاج.'; }
}
