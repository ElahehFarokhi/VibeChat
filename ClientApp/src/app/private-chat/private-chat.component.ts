import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { MessagesComponent } from '../messages/messages.component';
import { ChatInputComponent } from '../chat-input/chat-input.component';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { ChatService } from '../services/chat.service';

@Component({
  selector: 'app-private-chat',
  standalone: true,
  imports: [MessagesComponent, ChatInputComponent],
  templateUrl: './private-chat.component.html',
  styleUrl: './private-chat.component.css'
})
export class PrivateChatComponent implements OnInit, OnDestroy{
  @Input() toUser = '';
  constructor(public activeModal: NgbActiveModal, public chatService: ChatService) { }

  ngOnInit(): void {

  }
  ngOnDestroy(): void {
    this.chatService.closePrivateChatMessage(this.toUser);
  }

  sendMessage(content: string){
    this.chatService.sendPrivateMessage(this.toUser, content);
  }
}
