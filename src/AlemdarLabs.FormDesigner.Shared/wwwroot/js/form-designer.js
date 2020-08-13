let formDesigner = {
  highlihter: {
    node: null
  },
  utils: {}
};

formDesigner.highlihter.activate = (event, cssClassName) => {
  let currentNode = event.target;
  while (currentNode.parentNode) {
    if (/\w-element/.test(currentNode.className)) {
      if (formDesigner.highlihter.node === currentNode) {
        return;
      }
      if (formDesigner.highlihter.node) {
        formDesigner.highlihter.node.className = formDesigner.highlihter.node.className.replace(cssClassName, '').trim();
      }
      currentNode.className += ' ' + cssClassName;
      formDesigner.highlihter.node = currentNode;
      return;
    }
    currentNode = currentNode.parentNode;
  }
};

formDesigner.highlihter.deactivate = (event, cssClassName) => {
  if (formDesigner.highlihter.node) {
    formDesigner.highlihter.node.className = formDesigner.highlihter.node.className.replace(cssClassName, '');
    formDesigner.highlihter.node = null;
  }
};

formDesigner.utils.addClass = (element, classList) => {
  let classArr = classList.split(" ");
  for (let i = 0; i < classArr.length; i++) {
    element.classList.add(classArr[i]);
  }
}

formDesigner.utils.removeClass = function (element, classList) {
  let classArr = classList.split(" ");
  for (let i = 0; i < classArr.length; i++) {
    element.classList.remove(classArr[i]);
  }
}

formDesigner.utils.removeClassById = function (elementId, classList) {
  let element = document.getElementById(elementId);
  if (element === null || element === {} || element === undefined) {
    console.error("Element is not found. Element Id: " + elementId);
    return;
  }
  formDesigner.utils.removeClass(element, classList);
};

window.formDesigner = formDesigner;