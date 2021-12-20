#include <stdio.h>

struct cvor{
	int x;
	struct cvor *left, *right;
}


void ubaci(struct cvor *r, struct cvor *p){
	if((r->right == NULL) && (p->x > r->x)){
		r->right = p;
	}else if((r->right != NULL) && (p->x > r->x)){
		ubaci(r->right, p);
	}

	if((r->left == NULL) && (p->x < r->x)){
		r->left = p;
	}else if((r->left != NULL) && (p->x < r->x)){
		ubaci(r->left, p);
	}
}


void preOrder(stuct cvor* root){
	if(root == NULL)return;
	else{
		printf(root->x);
		preOrder(root->left);
		preOrder(root->right);
	}
}


void inOrder(struct cvor* root){
	if(root == NULL)return;
	else{
		preOrder(root->left);
		printf(root->x);
		preOrder(root->right);
	}
}


void postOrder(struct cvor* root){
	if(root == NULL)return;
	else{
		preOrder(root->left);
		preOrder(root->right);
		printf(root->x);
	}
}


int main(){
	//kreiraj binarno stablo
	//pozovi umetni f-ju
	//ispisi sve sa 3 metode
	return 0;
}