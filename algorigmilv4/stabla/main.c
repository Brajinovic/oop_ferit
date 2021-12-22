#include <stdio.h>
#include <stdlib.h>

struct cvor{
	int x;
	struct cvor *left, *right;
};

int FindP(char P, struct cvor *head, struct cvor* parent){
	if(head->x == NULL){
		return -1;//didn't find the number
	}
	if(head->x == P){
		return 1;
	}
	parent = head;
	if(head->x > P){
		FindP(P, head->left, parent);
	}else
		FindP(P, head->right, parent);
}

void insert(struct cvor *head, char P, struct cvor* parent){
	if(FindP(P, head, parent)==1){
		printf("Takav Element vec postoji u stablu!!!\n");
	}else{
		struct cvor* new = (struct cvor*)malloc(1*sizeof(struct cvor));
		new->x = P;
		new->right = NULL;
		new->left = NULL;

		if(parent == NULL){
			head = new;
		}else{
			if(P < parent->x){
				parent->left = new;
			}else{
				parent->right = new;
			}
		}
}
}


void preOrder(struct cvor* root){
	if(root == NULL)
		printf(root->x);
		preOrder(root->left);
		preOrder(root->right);
}


void inOrder(struct cvor* root){
	if(root != NULL)
		preOrder(root->left);
		printf(root->x);
		preOrder(root->right);
}



void postOrder(struct cvor* root){
	if(root != NULL)
		preOrder(root->left);
		preOrder(root->right);
		printf(root->x);
}


struct cvor* CreateHead(int value){
	struct cvor *head = (struct cvor*)malloc(sizeof(struct cvor));
	head->x = value;
	head->left = NULL;
	head->right = NULL;
	return head;
}



int main(){
	printf("here");
	char name[14] = {'i', 'v', 'a', 'n', 'b', 'r', 'a', 'j', 'i', 'n', 'o', 'v', 'i', 'c'};
	printf("here");
	struct cvor *head = (struct cvor*)malloc(sizeof(struct cvor));
	struct cvor *parent = (struct cvor*)malloc(sizeof(struct cvor));
	parent = NULL;
	head->x = name[0];
	head->left = NULL;
	printf("here");
	head->right = NULL;
	for(int i = 1; i < 14; i++){
		insert(head, name[i], parent);
	}
	//ispisi sve sa 3 metode
	printf("preOrder: \t");
	preOrder(head);
	printf("inOrder: \t");
	inOrder(head);
	printf("postOrder: \t");
	postOrder(head);
	return 0;
}