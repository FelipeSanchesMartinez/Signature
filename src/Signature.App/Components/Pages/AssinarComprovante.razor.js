const canvas = document.querySelector("canvas");

const signaturePad = new SignaturePad(canvas);

export function clear() {
    signaturePad.clear();
}

export function isEmpty() {
    return signaturePad.isEmpty();
}

export function getBase64() {
    return signaturePad.toDataURL("image/jpeg");
}

export function alerta(message) {
    alert(message);
}


