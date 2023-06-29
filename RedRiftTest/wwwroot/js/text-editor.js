export function openDialog(id) {
    document.getElementById(id).showModal();
}

export function closeDialog(id) {
    const dialog = document.getElementById(id);
    if (dialog.open) {
        dialog.close();
    }
}